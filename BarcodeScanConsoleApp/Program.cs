using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using System.Drawing;
using ZXing.QrCode;
using ZXing.Common;
using System.Drawing.Imaging;
using System.IO;
namespace BarcodeScanConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a barcode reader instance
            var barcodeReader = new BarcodeReader {AutoRotate=true};

            // create an in memory bitmap
            //var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\temp\authdoc079790-1.tif");
            var pages = GetAllPages(@"C:\temp\authdoc079790-1.tif");
            foreach (var page in pages)
            {
                Bitmap bmp = (Bitmap)page;
                var barcodeResult = barcodeReader.Decode(bmp);
            }
            // decode the barcode from the in memory bitmap
            //var barcodeResult = barcodeReader.Decode(barcodeBitmap);

            // output results to console
            //Console.WriteLine($"Decoded barcode text: {barcodeResult?.Text}");
            //Console.WriteLine($"Barcode format: {barcodeResult?.BarcodeFormat}");


            //var barcodeReader = new BarcodeReader();

            ////IBarcodeReader reader = new BarcodeReader();
            //// load a bitmap
            //var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\temp\test.bmp");
            //// detect and decode the barcode inside the bitmap
            //var result = barcodeReader.Decode(barcodeBitmap);
            //// do something with the result
            //if (result != null)
            //{
            //    Console.WriteLine(result.BarcodeFormat.ToString());
            //    Console.WriteLine(result.Text);
            //}


            //string path = @"c:\temp\test.png";
            //Bitmap originalImage = (Bitmap)Bitmap.FromFile(path);

            //ImageConverter imCo = new ImageConverter();
            //byte[] bbt = (byte[])imCo.ConvertTo(originalImage, typeof(byte[]));

            //IDictionary<DecodeHintType, object> hintMap = new Dictionary<DecodeHintType, object>();
            //hintMap.Add(DecodeHintType.TRY_HARDER, true);

            //LuminanceSource source = new RGBLuminanceSource(bbt, originalImage.Width, originalImage.Height);
            //BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));

            //// decode the barcode
            //QRCodeReader reader = new QRCodeReader();
            //BarcodeReader rr = new BarcodeReader();
            //rr.Options.PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE };

            //Result result = null;
            //try
            //{
            //    Result[] results = rr.DecodeMultiple(source);
            //    result = reader.decode(bitmap, hintMap);
            //}
            //catch (ReaderException e)
            //{
            //}
        }
        private static List<Image> GetAllPages(string file)
        {
            List<Image> images = new List<Image>();
            Bitmap bitmap = (Bitmap)Image.FromFile(file);
            int count = bitmap.GetFrameCount(FrameDimension.Page);
            for (int idx = 0; idx < count; idx++)
            {
                // save each frame to a bytestream
                bitmap.SelectActiveFrame(FrameDimension.Page, idx);
                MemoryStream byteStream = new MemoryStream();
                bitmap.Save(byteStream, ImageFormat.Tiff);

                // and then create a new Image from it
                images.Add(Image.FromStream(byteStream));
            }
            return images;
        }
    }
}
