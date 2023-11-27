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
using WebCamLib;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loadedImage;
        Bitmap processedImage;
        Bitmap imageA;
        Bitmap imageB;
        Bitmap imageC;
        Device[] webcams = DeviceManager.GetAllDevices();
        Device webcam;
        private Timer cameraTimer;

        public Form1()
        {
            InitializeComponent();
            pnlOriginal.BringToFront();
            webcam = webcams[0];

            cameraTimer = new Timer();
            cameraTimer.Interval = 5000; // 5 seconds interval
            cameraTimer.Tick += cameraTimer_Tick;
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

        private void useSubtractToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pnlOriginal.Visible)
            {
                // Turn on
                pnlOriginal.Visible = false;
                pnlSubtract.Visible = true;
                fileToolStripMenuItem.Enabled = false;
                imageToolStripMenuItem.Enabled = true;

                pnlSubtract.BringToFront(); // Bring the control to the front\
            }
            else
            {
                // Turn off
                pnlOriginal.Visible = true;
                pnlSubtract.Visible = false;
                fileToolStripMenuItem.Enabled = true;
                imageToolStripMenuItem.Enabled = false;
                
                pnlOriginal.BringToFront();
            }
        }

        private void cbCamera_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCamera.Checked == true)
            {
                btnUploadBackground.Enabled = false;
                btnSubtract.Enabled = false;
                cbFilter.Visible = true;

                // Show the webcam preview

                if (webcam != null)
                {
                    webcam.ShowWindow(pbSubtract2);
                }
            }
            else
            {
                btnUploadBackground.Enabled = true;
                btnSubtract.Enabled = true;
                cbFilter.Visible = false;

                if (webcam != null)
                {
                    webcam.Stop();
                }
            }
            
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = @"C:\Downloads";

            // add filter for files only
            openFileDialog2.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog2.FileName;

                imageB = new Bitmap(selectedFilePath);

                // Display the Image File
                pbSubtract1.Image = imageB;
            }
        }

        private void btnUploadBackground_Click(object sender, EventArgs e)
        {
            openFileDialog3.InitialDirectory = @"C:\Downloads";

            // add filter for files only
            openFileDialog3.Filter = "Image files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";


            // Show the dialog and check if the user clicked OK
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path
                string selectedFilePath = openFileDialog3.FileName;

                imageA = new Bitmap(selectedFilePath);

                // Display the Image File
                pbSubtract2.Image = imageA;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if(imageA != null)
                if(imageB != null)
                {
                    ImageProcessor.Subtract(ref imageA, ref imageB, ref imageC);
                    pbSubtractOutput.Image = imageC;
                } else
                {
                    MessageBox.Show("Please upload image B", "Missing Image B", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            else
            {
                MessageBox.Show("Please upload a background image", "Missing Image A", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilter.Checked == true)
            {
                if (imageB != null)
                {
                    ApplySubtract();
                    cameraTimer.Start();
                }
                else
                {
                    cbFilter.Checked = false;
                    MessageBox.Show("Please upload a image B", "Missing Image B", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cameraTimer.Stop();
            }
        }

        private void cameraTimer_Tick(object sender, EventArgs e)
        {
            ApplySubtract();
        }

        private void ApplySubtract()
        {
            webcam.sendMessage();

            imageA = new Bitmap(Clipboard.GetImage());

            ImageProcessor.Subtract(ref imageA, ref imageB, ref imageC);

            pbSubtractOutput.Image = imageC;
        }
    }
}
