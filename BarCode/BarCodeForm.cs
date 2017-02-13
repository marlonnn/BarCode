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
    public partial class BarCodeForm : Form
    {
        //条码的宽高
        private int codeWidth = 300;
        private int codeHeight = 150;

        private Bitmap barCodeImage = null;
        private ImageFormat imageformat;

        public BarCodeForm()
        {
            InitializeComponent();
            this.txtWidth.Text = codeWidth.ToString();
            this.txtHeight.Text = codeHeight.ToString();
        }

        private void BarCodeForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.cbEncodeType.DataSource = System.Enum.GetNames(typeof(BarcodeFormat));
                this.cbEncodeType.SelectedIndex = 4;
            }
            catch (Exception exception)
            {

            }
        }

        //生成条形码
        private void btnEncodeBarCode_Click(object sender, EventArgs e)
        {
            try
            {
                // 1.设置条形码规格
                EncodingOptions encodeOption = new EncodingOptions();
                encodeOption.Height = codeHeight; // 必须制定高度、宽度
                encodeOption.Width = codeWidth;

                // 2.生成条形码图片并保存
                BarcodeWriter wr = new BarcodeWriter();
                wr.Options = encodeOption;
                var format = BarcodeFormatHelper.GetFormat(this.cbEncodeType.SelectedItem.ToString());
                wr.Format = format; //  条形码规格：EAN13规格：12（无校验位）或13位数字
                barCodeImage = wr.Write(this.txtData.Text); // 生成图片
                this.barcode.BackgroundImage = barCodeImage;
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
                this.codeWidth = Int32.Parse(this.txtWidth.Text.ToString());
            }
            catch (Exception ee)
            {
            }
        }

        //修改条形码高度
        private void BarHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.codeHeight = Int32.Parse(this.txtHeight.Text.ToString());
            }
            catch (Exception ee)
            {
            }
        }

        //读取并解析条形码
        private void btnDecodeBarCode_Click(object sender, EventArgs e)
        {
            if (barCodeImage != null)
            {
                // 1.设置读取条形码规格
                DecodingOptions decodeOption = new DecodingOptions();
                decodeOption.PossibleFormats = new List<BarcodeFormat>() {
               BarcodeFormatHelper.GetFormat(this.cbEncodeType.SelectedItem.ToString()),
            };

                // 2.进行读取操作
                BarcodeReader br = new BarcodeReader();
                br.Options = decodeOption;
                Result rs = br.Decode(barCodeImage);
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
            if (barCodeImage != null)
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
                            imageformat = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                        case 2: /* GIF */
                            imageformat = System.Drawing.Imaging.ImageFormat.Gif;
                            break;
                        case 3: /* JPG */
                            imageformat = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case 4: /* PNG */
                            imageformat = System.Drawing.Imaging.ImageFormat.Png;
                            break;
                        case 5: /* TIFF */
                            imageformat = System.Drawing.Imaging.ImageFormat.Tiff;
                            break;
                        default: break;
                    }
                    barCodeImage.Save(sfd.FileName, imageformat);
                }
            }
        }
    }
}
