using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
            openFileToolStripMenuItem.Enabled = false;
            openFileDialog1.Title = "Choose an image";

            openFileDialog1.InitialDirectory = @"C:\Downloads";

            // add filter for files only
            openFileDialog1.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog1.FileName;

                loadedImage = new Bitmap(selectedFilePath);

                // Display the Image File
                pbLoaded.Image = loadedImage;

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
            imageToolStripMenuItem.Enabled = false;

            openFileDialog1.Title = "Choose an image";

            openFileDialog1.InitialDirectory = @"C:\Downloads";

            // add filter for files only
            openFileDialog1.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog1.FileName;

                loadedImage = new Bitmap(selectedFilePath);

                // Display the new Image File
                pbLoaded.Image = loadedImage;
            }
        }

        private void basicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;
            imageToolStripMenuItem.Enabled = true;

            processedImage = ImageProcessor.BasicCopy(loadedImage);
            pbProcessed.Image = processedImage;
            lblProcessed.Text = "Basic Copy of Loaded Image";
        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;
            imageToolStripMenuItem.Enabled = true;

            processedImage = ImageProcessor.GrayScale(loadedImage);
            pbProcessed.Image = processedImage;
            lblProcessed.Text = "Gray Scale of Loaded Image";
        }

        private void inverseImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;
            imageToolStripMenuItem.Enabled = true;

            processedImage = ImageProcessor.InvertImage(loadedImage);
            pbProcessed.Image = processedImage;
            lblProcessed.Text = "Inverted Image of Loaded Image";
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;
            imageToolStripMenuItem.Enabled = true;

            processedImage = ImageProcessor.Histogram(loadedImage);
            pbProcessed.Image = processedImage;
            lblProcessed.Text = "Histogram of Loaded Image";
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbProcessed.Visible = true;
            lblProcessed.Visible = true;
            imageToolStripMenuItem.Enabled = true;

            processedImage = ImageProcessor.ApplySepia(loadedImage);
            pbProcessed.Image = processedImage;
            lblProcessed.Text = "Loaded Image with Sepia Filter";
        }

        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Processed Image";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                processedImage.Save(saveFileDialog.FileName, ImageFormat.Png);
                MessageBox.Show("Image saved successfully.");
            }
        }

        private void madeByJohnIvanPuayapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
