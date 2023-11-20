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


        
        public Form1()
        {
            InitializeComponent();
        }

        Image loadedImage;

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

                loadedImage = Image.FromFile(selectedFilePath);

                // Display the Image File
                Image scaledImage = ScaleImage
                pbLoaded.Image = scaledImage;

                // enable the Activity 1 Strip Menu Item
                activity1ToolStripMenuItem.Enabled = true;
            }
        }
    }
}
