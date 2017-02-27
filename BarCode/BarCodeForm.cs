using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace BarCode
{
    /// <summary>
    /// 条形码/二维码生成和识别程序
    /// </summary>
    public partial class BarCodeForm : Form
    {
        //条码的宽高
        private int CodeMethod = 300;
        private int CodeHeight = 150;

        //条形码/二维码图像对象
        private Bitmap BarCodeImage = null;
        //保存图片格式
        private ImageFormat Imageformat;

        public BarCodeForm()
        {
            InitializeComponent();
            this.txtWidth.Text = CodeMethod.ToString();
            this.txtHeight.Text = CodeHeight.ToString();
        }

        private void BarCodeForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.cbEncodeType.DataSource = System.Enum.GetNames(typeof(BarcodeFormat));
                this.cbEncodeType.SelectedIndex = 4;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace, "Exception", MessageBoxButtons.OK);
            }
        }

        //生成条形码
        private void btnEncodeBarCode_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.设置条形码规格
                EncodingOptions encodeOption = new EncodingOptions();
                encodeOption.Height = CodeHeight; // 必须制定高度、宽度
                encodeOption.Width = CodeMethod;

                // 2.生成条形码图片并保存
                BarcodeWriter wr = new BarcodeWriter();
                wr.Options = encodeOption;
                var format = BarcodeFormatHelper.GetFormat(this.cbEncodeType.SelectedItem.ToString());
                wr.Format = format; //  条形码规格：EAN13规格：12（无校验位）或13位数字
                BarCodeImage = wr.Write(this.txtData.Text); // 生成图片
                this.barcode.BackgroundImage = BarCodeImage;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK);
            }
        }

        //修改条形码宽度
        private void BarWidth_TectChanged(object sender, EventArgs e)
        {
            try
            {
                this.CodeMethod = Int32.Parse(this.txtWidth.Text.ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace, "Exception", MessageBoxButtons.OK);
            }
        }

        //修改条形码高度
        private void BarHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.CodeHeight = Int32.Parse(this.txtHeight.Text.ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.StackTrace, "Exception", MessageBoxButtons.OK);
            }
        }

        //读取并解析条形码
        private void btnDecodeBarCode_Click(object sender, EventArgs e)
        {
            if (BarCodeImage != null)
            {
                // 1.设置读取条形码规格
                DecodingOptions decodeOption = new DecodingOptions();
                decodeOption.PossibleFormats = new List<BarcodeFormat>() {
               BarcodeFormatHelper.GetFormat(this.cbEncodeType.SelectedItem.ToString()),
            };

                // 2.进行读取操作
                BarcodeReader br = new BarcodeReader();
                br.Options = decodeOption;
                Result rs = br.Decode(BarCodeImage);
                if (rs == null)
                {
                    MessageBox.Show("读取失败");
                }
                else
                {
                    MessageBox.Show("读取成功，内容：" + rs.Text);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BarCodeImage != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
                sfd.FilterIndex = 2;
                sfd.AddExtension = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: /* BMP */
                            {
                                Imageformat = System.Drawing.Imaging.ImageFormat.Bmp;
                            }
                            break;
                        case 2: /* GIF */
                            {
                                Imageformat = System.Drawing.Imaging.ImageFormat.Gif;
                            }
                            break;
                        case 3: /* JPG */
                            {
                                Imageformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                            }
                            break;
                        case 4: /* PNG */
                            {
                                Imageformat = System.Drawing.Imaging.ImageFormat.Png;
                            }
                            break;
                        case 5: /* TIFF */
                            {
                                Imageformat = System.Drawing.Imaging.ImageFormat.Tiff;
                            }
                            break;
                        default: break;
                    }
                    BarCodeImage.Save(sfd.FileName, Imageformat);
                }
            }
        }
    }
}
