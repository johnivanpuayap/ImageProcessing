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
                    processed.SetPixel(x, (processed.Height - 1) - y, Color.FromArgb(100, 100, 100));
                }
            }

            return processed;
        }

        public static Bitmap ApplySepia(Bitmap inputImage)
        {
            Bitmap processedImage = new Bitmap(inputImage.Width, inputImage.Height);

            for (int i = 0; i < inputImage.Width; i++)
            {
                for (int j = 0; j < inputImage.Height; j++)
                {
                    Color pixel = inputImage.GetPixel(i, j);

                    int originalR = pixel.R;
                    int originalG = pixel.G;
                    int originalB = pixel.B;

                    // Calculate sepia values
                    int sepiaR = (int)(0.393 * originalR + 0.769 * originalG + 0.189 * originalB);
                    int sepiaG = (int)(0.349 * originalR + 0.686 * originalG + 0.168 * originalB);
                    int sepiaB = (int)(0.272 * originalR + 0.534 * originalG + 0.131 * originalB);

                    // Ensure sepia values are within the valid range [0, 255]
                    sepiaR = Math.Max(0, Math.Min(255, sepiaR));
                    sepiaG = Math.Max(0, Math.Min(255, sepiaG));
                    sepiaB = Math.Max(0, Math.Min(255, sepiaB));

                    processedImage.SetPixel(i, j, Color.FromArgb(sepiaR, sepiaG, sepiaB));
                }
            }

            return processedImage;
        }

        public static Bitmap Subtract(Bitmap imageA, Bitmap imageB)
        {
            Bitmap processedImage = new Bitmap(imageB.Width, imageB.Height);
            Color myGreen = Color.FromArgb(0, 0, 255);
            int greygreen = (myGreen.R + myGreen.G + myGreen.B) / 3;
            int threshold = 5;

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalue = Math.Abs(grey - greygreen);
                    processedImage.SetPixel(x, y, subtractvalue > threshold ? pixel : backpixel);
                }
            }

            return processedImage;
        }

        public static Bitmap ApplyGreenScreenEffect(ref Bitmap loaded, ref Bitmap )
        {
            Bitmap bitmap = new Bitmap(loaded);
            Color chromaKeyColor = Color.FromArgb(0, 255, 0); // Green color
            int tolerance = 100; // Adjust as needed

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Check if the pixel color is close to the chroma key color
                    if (ColorDistance(pixelColor, chromaKeyColor) < tolerance)
                    {
                        // If close, set the pixel color to transparent
                        bitmap.SetPixel(x, y, Color.Transparent);
                    }
                    // You may want to adjust the else part based on your specific requirements
                }
            }

            return bitmap;
        }

        private static int ColorDistance(Color c1, Color c2)
        {
            int rDiff = Math.Abs(c1.R - c2.R);
            int gDiff = Math.Abs(c1.G - c2.G);
            int bDiff = Math.Abs(c1.B - c2.B);

            return rDiff + gDiff + bDiff;
        }
    }
}
