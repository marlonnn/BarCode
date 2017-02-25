using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;

namespace BarCode
{
    public class Barcode : IDisposable
    {
        private Image encodedImage = null;
        private int width = 300;
        private int height = 150;
        private ImageFormat imageFormat = ImageFormat.Jpeg;
        private Font labelFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);

        /// <summary>
        /// 标签位置
        /// </summary>
        public enum LabelPositions : int { TOPLEFT, TOPCENTER, TOPRIGHT, BOTTOMLEFT, BOTTOMCENTER, BOTTOMRIGHT };

        private LabelPositions labelPosition = LabelPositions.BOTTOMCENTER;
        private string rawData = "";
        private BarcodeFormat type;

        #region 构造函数
        public Barcode()
        {

        }

        public Barcode(string rowData)
        {
            this.rawData = rowData;
        }

        public Barcode(string rawData, BarcodeFormat type)
        {
            this.rawData = rawData;
            this.type = type;
        }
        #endregion

        //需要编码的数据
        public string RawData
        {
            get { return this.rawData; }
            set { this.rawData = value; }
        }

        //编码格式
        public BarcodeFormat EncodedType
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //条形码或者二维码
        public Image EncodedImage
        {
            get
            {
                return encodedImage;
            }
        }

        /// <summary>
        /// Gets or sets the label font. (Default is Microsoft Sans Serif, 10pt, Bold)
        /// </summary>
        public Font LabelFont
        {
            get { return this.labelFont; }
            set { this.labelFont = value; }
        }

        /// <summary>
        /// Gets or sets the location of the label in relation to the barcode. (BOTTOMCENTER is default)
        /// </summary>
        public LabelPositions LabelPosition
        {
            get { return labelPosition; }
            set { labelPosition = value; }
        }

        /// <summary>
        /// Gets or sets the width of the image to be drawn. (Default is 300 pixels)
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        /// <summary>
        /// Gets or sets the height of the image to be drawn. (Default is 150 pixels)
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        ///   If non-null, sets the width of a bar. <see cref="Width"/> is ignored and calculated automatically.
        /// </summary>
        public int? BarWidth { get; set; }

        /// <summary>
        /// Gets or sets the amount of time in milliseconds that it took to encode and draw the barcode.
        /// </summary>
        public double EncodingTime
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image format to use when encoding and returning images. (Jpeg is default)
        /// </summary>
        public ImageFormat ImageFormat
        {
            get { return imageFormat; }
            set { imageFormat = value; }
        }
        public void Dispose()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw new Exception("EDISPOSE-1: " + ex.Message);
            }
        }
    }
}
