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
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ZXingNetBarCodeApp
{
    public partial class BarCode : Form
    {
        public BarCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                var barcodeReader = new BarcodeReader { AutoRotate = true };

                // create an in memory bitmap
                //var barcodeBitmap = (Bitmap)Bitmap.FromFile(@"C:\temp\authdoc079790-1.tif");
                //var pages = GetAllPages(@"C:\temp\authdoc079790-1.tif");
                var pages = GetAllPages(openFileDialog1.FileName);
                
                foreach (var page in pages)
                {
                    Bitmap bmp = (Bitmap)page;
                    var barcodeResult = barcodeReader.Decode(bmp);
                    if (barcodeResult != null) 
                        lblBaiCodeValue.Text = barcodeResult.Text;
                    else
                        lblBaiCodeValue.Text = "Can't Read Bar Code";
                }
            }
            //Console.WriteLine(result); // <-- For debugging use.
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            pbQRCode.Image = encodeToQrCode(txtInputBarCode.Text, 200, 200);
            pbQRCode.Image.Save(@"C:\temp\QRCode\"+Guid.NewGuid().ToString() +".bmp"); 
        }
        public static Bitmap encodeToQrCode(String text, int width, int height)
        {
            QRCodeWriter writer = new QRCodeWriter();
            BitMatrix matrix = null;
            try
            {
                matrix = writer.encode(text, BarcodeFormat.QR_CODE, width, width);
            }
            catch (WriterException ex)
            {
                //ex.printStackTrace();
            }
            Bitmap bmp = new Bitmap(width, height); 
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bmp.SetPixel(x, y, matrix[x, y] ? Color.Black : Color.White);
                }
            }
            return bmp;
        }

    }
}
