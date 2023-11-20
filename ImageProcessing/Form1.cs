using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {


        Bitmap loadedImage;
        Bitmap processedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            openFileDialog1.Title = "Choose an image";

            openFileDialog1.InitialDirectory = @"C:\";

            // add filter for files only
            openFileDialog1.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog1.FileName;

                loadedImage = new Bitmap(selectedFilePath);

                // Display the Image File
                if (loadedImage.Width > 500 || loadedImage.Height > 500)
                {
                    // Scale the image only if its size is greater than 500x500
                    Bitmap scaledImage = ImageProcessor.ScaleImage(loadedImage, 500, 500);
                    pbLoaded.Image = scaledImage;
                }
                else
                {
                    // If the image is smaller or equal to 500x500, use the original processed image
                    pbLoaded.Image = loadedImage;
                }

                // enable the Activity 1 Strip Menu Item and change Image
                lblLoaded.Visible = true;
                activity1ToolStripMenuItem.Enabled = true;
                changeFileToolStripMenuItem.Enabled = true;
            }
        }

        private void changeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the 2nd Picture Box and Label
            pbProcessed.Visible = false;
            lblProcessed.Visible = false;

            openFileDialog1.Title = "Choose an image";

            openFileDialog1.InitialDirectory = @"C:\";

            // add filter for files only
            openFileDialog1.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog1.FileName;

                loadedImage = new Bitmap(selectedFilePath);

                // Display the new Image File
                if (loadedImage.Width > 500 || loadedImage.Height > 500)
                {
                    // Scale the image only if its size is greater than 500x500
                    Bitmap scaledImage = ImageProcessor.ScaleImage(loadedImage, 500, 500);
                    pbLoaded.Image = scaledImage;
                }
                else
                {
                    // If the image is smaller or equal to 500x500, use the original processed image
                    pbLoaded.Image = loadedImage;
                }
            }
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;

            processedImage = ImageProcessor.BasicCopy(loadedImage);

            if (loadedImage.Width > 500 || loadedImage.Height > 500)
            {
                // Scale the image only if its size is greater than 500x500
                Bitmap scaledProcessedImage = ImageProcessor.ScaleImage(processedImage, 500, 500);
                pbProcessed.Image = scaledProcessedImage;
            }
            else
            {
                // If the image is smaller or equal to 500x500, use the original processed image
                pbProcessed.Image = processedImage;
            }
            lblProcessed.Text = "Basic Copy of Loaded Image";
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;

            processedImage = ImageProcessor.GrayScale(loadedImage);

            if (loadedImage.Width > 500 || loadedImage.Height > 500)
            {
                // Scale the image only if its size is greater than 500x500
                Bitmap scaledProcessedImage = ImageProcessor.ScaleImage(processedImage, 500, 500);
                pbProcessed.Image = scaledProcessedImage;
            }
            else
            {
                // If the image is smaller or equal to 500x500, use the original processed image
                pbProcessed.Image = processedImage;
            }

            lblProcessed.Text = "Gray Scale of Loaded Image";
        }

        private void inverseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;

            processedImage = ImageProcessor.InvertImage(loadedImage);

            if (loadedImage.Width > 500 || loadedImage.Height > 500)
            {
                // Scale the image only if its size is greater than 500x500
                Bitmap scaledProcessedImage = ImageProcessor.ScaleImage(processedImage, 500, 500);
                pbProcessed.Image = scaledProcessedImage;
            }
            else
            {
                // If the image is smaller or equal to 500x500, use the original processed image
                pbProcessed.Image = processedImage;
            }

            lblProcessed.Text = "Inverted Image of Loaded Image";
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;

            processedImage = ImageProcessor.Histogram(loadedImage);

            if (loadedImage.Width > 500 || loadedImage.Height > 500)
            {
                // Scale the image only if its size is greater than 500x500
                Bitmap scaledProcessedImage = ImageProcessor.ScaleImage(processedImage, 500, 500);
                pbProcessed.Image = scaledProcessedImage;
            }
            else
            {
                // If the image is smaller or equal to 500x500, use the original processed image
                pbProcessed.Image = processedImage;
            }

            lblProcessed.Text = "Histogram of Loaded Image";
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;

            processedImage = ImageProcessor.ApplySepia(loadedImage);

            if (loadedImage.Width > 500 || loadedImage.Height > 500)
            {
                // Scale the image only if its size is greater than 500x500
                Bitmap scaledProcessedImage = ImageProcessor.ScaleImage(processedImage, 500, 500);
                pbProcessed.Image = scaledProcessedImage;
            }
            else
            {
                // If the image is smaller or equal to 500x500, use the original processed image
                pbProcessed.Image = processedImage;
            }

            lblProcessed.Text = "Loaded Image with Sepia Filter";
        }
    }
}
