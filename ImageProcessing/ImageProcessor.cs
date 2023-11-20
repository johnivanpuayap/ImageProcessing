using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public static class ImageProcessor
    {
        public static Bitmap ScaleImage(Bitmap image, int maxWidth, int maxHeight)
        {
            double ratioX = (double)maxWidth / image.Width;
            double ratioY = (double)maxHeight / image.Height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            Bitmap newImage = new Bitmap(newWidth, newHeight, image.PixelFormat);

            newImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }

            return newImage;
        }

        public static Bitmap BasicCopy(Bitmap loaded)
        {
            Bitmap processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel(i, j, pixel);
                }
            }

            return processed;
        }

        public static Bitmap GrayScale(Bitmap loaded)
        {
            Bitmap processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            byte gray;
            processed = new Bitmap(loaded.Width, loaded.Height);
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    gray = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                    processed.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return processed;
        }

        public static Bitmap InvertImage(Bitmap loaded)
        {
            Color pixel;
            Bitmap processed = new Bitmap(loaded.Width, loaded.Height);
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel(i, j, Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B));
                }
            }
            
            return processed;
        }

        public static Bitmap Histogram(Bitmap loaded)
        {
            // Convert loaded Image to Gray
            Bitmap loadedGray = GrayScale(loaded);
            Color pixel;
            int[] histogramData = new int[256]; // array from 0 to 255

            for (int x = 0; x < loadedGray.Width; x++)
            {
                for (int y = 0; y < loadedGray.Height; y++)
                {
                    pixel = loadedGray.GetPixel(x, y);
                    histogramData[pixel.R]++; // can be any color property r,g or b
                }
            }

            // Creating a bitmap with white background
            Bitmap processed = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    processed.SetPixel(x, y, Color.White);
                }
            }

            // Plotting points based on histogramData
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histogramData[x] / 5, processed.Height - 1); y++)
                {
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.Black);
                }
            }

            return processed;
        }
    }
}
