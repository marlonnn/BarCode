using ZXing;

namespace BarCode
{
    public static class BarcodeFormatHelper
    {
        public static BarcodeFormat GetFormat(string format)
        {
            BarcodeFormat barcodeFormat = BarcodeFormat.EAN_13;
            switch (format)
            {
                case "AZTEC":
                    barcodeFormat = BarcodeFormat.AZTEC;
                    break;
                case "CODABAR":
                    barcodeFormat = BarcodeFormat.CODABAR;
                    break;
                case "CODE_39":
                    barcodeFormat = BarcodeFormat.CODE_39;
                    break;
                case "CODE_93":
                    barcodeFormat = BarcodeFormat.CODE_93;
                    break;
                case "CODE_128":
                    barcodeFormat = BarcodeFormat.CODE_128;
                    break;
                case "DATA_MATRIX":
                    barcodeFormat = BarcodeFormat.DATA_MATRIX;
                    break;
                case "EAN_8":
                    barcodeFormat = BarcodeFormat.EAN_8;
                    break;
                case "EAN_13":
                    barcodeFormat = BarcodeFormat.EAN_13;
                    break;
                case "ITF":
                    barcodeFormat = BarcodeFormat.ITF;
                    break;
                case "MAXICODE":
                    barcodeFormat = BarcodeFormat.MAXICODE;
                    break;
                case "PDF_417":
                    barcodeFormat = BarcodeFormat.PDF_417;
                    break;
                case "QR_CODE":
                    barcodeFormat = BarcodeFormat.QR_CODE;
                    break;
                case "RSS_14":
                    barcodeFormat = BarcodeFormat.RSS_14;
                    break;
                case "RSS_EXPANDED":
                    barcodeFormat = BarcodeFormat.RSS_EXPANDED;
                    break;
                case "UPC_A":
                    barcodeFormat = BarcodeFormat.UPC_A;
                    break;
                case "UPC_E":
                    barcodeFormat = BarcodeFormat.UPC_E;
                    break;
                case "All_1D":
                    barcodeFormat = BarcodeFormat.All_1D;
                    break;
                case "UPC_EAN_EXTENSION":
                    barcodeFormat = BarcodeFormat.UPC_EAN_EXTENSION;
                    break;
                case "MSI":
                    barcodeFormat = BarcodeFormat.MSI;
                    break;
                case "PLESSEY":
                    barcodeFormat = BarcodeFormat.PLESSEY;
                    break;

            }
            return barcodeFormat;
        }
    }
}
