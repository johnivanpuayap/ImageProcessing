namespace ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLoaded = new System.Windows.Forms.PictureBox();
            this.pbProcessed = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activity1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useSubtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByJohnIvanPuayapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLoaded = new System.Windows.Forms.Label();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbSubtract1 = new System.Windows.Forms.PictureBox();
            this.pbSubtract2 = new System.Windows.Forms.PictureBox();
            this.pbSubtractOutput = new System.Windows.Forms.PictureBox();
            this.pnlSubtract = new System.Windows.Forms.Panel();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnUploadBackground = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.CheckBox();
            this.pnlOriginal = new System.Windows.Forms.Panel();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtractOutput)).BeginInit();
            this.pnlSubtract.SuspendLayout();
            this.pnlOriginal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLoaded
            // 
            this.pbLoaded.Location = new System.Drawing.Point(57, 29);
            this.pbLoaded.Name = "pbLoaded";
            this.pbLoaded.Size = new System.Drawing.Size(500, 500);
            this.pbLoaded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoaded.TabIndex = 0;
            this.pbLoaded.TabStop = false;
            // 
            // pbProcessed
            // 
            this.pbProcessed.Location = new System.Drawing.Point(631, 29);
            this.pbProcessed.Name = "pbProcessed";
            this.pbProcessed.Size = new System.Drawing.Size(500, 500);
            this.pbProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProcessed.TabIndex = 1;
            this.pbProcessed.TabStop = false;
            this.pbProcessed.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.activity1ToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.substractToolStripMenuItem,
            this.abootToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.changeFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // changeFileToolStripMenuItem
            // 
            this.changeFileToolStripMenuItem.Enabled = false;
            this.changeFileToolStripMenuItem.Name = "changeFileToolStripMenuItem";
            this.changeFileToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.changeFileToolStripMenuItem.Text = "Change File";
            this.changeFileToolStripMenuItem.Click += new System.EventHandler(this.changeFileToolStripMenuItem_Click);
            // 
            // activity1ToolStripMenuItem
            // 
            this.activity1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCopyToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.inverseImageToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.activity1ToolStripMenuItem.Enabled = false;
            this.activity1ToolStripMenuItem.Name = "activity1ToolStripMenuItem";
            this.activity1ToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.activity1ToolStripMenuItem.Text = "Activity 1";
            // 
            // basicCopyToolStripMenuItem
            // 
            this.basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.grayToolStripMenuItem.Text = "Gray Scale";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // inverseImageToolStripMenuItem
            // 
            this.inverseImageToolStripMenuItem.Name = "inverseImageToolStripMenuItem";
            this.inverseImageToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.inverseImageToolStripMenuItem.Text = "Invert";
            this.inverseImageToolStripMenuItem.Click += new System.EventHandler(this.inverseImageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageToolStripMenuItem});
            this.imageToolStripMenuItem.Enabled = false;
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // substractToolStripMenuItem
            // 
            this.substractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useSubtractToolStripMenuItem});
            this.substractToolStripMenuItem.Name = "substractToolStripMenuItem";
            this.substractToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.substractToolStripMenuItem.Text = "Substract";
            // 
            // useSubtractToolStripMenuItem
            // 
            this.useSubtractToolStripMenuItem.Name = "useSubtractToolStripMenuItem";
            this.useSubtractToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.useSubtractToolStripMenuItem.Text = "Turn On/Off";
            this.useSubtractToolStripMenuItem.Click += new System.EventHandler(this.useSubtractToolStripMenuItem_Click);
            // 
            // abootToolStripMenuItem
            // 
            this.abootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByJohnIvanPuayapToolStripMenuItem});
            this.abootToolStripMenuItem.Name = "abootToolStripMenuItem";
            this.abootToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.abootToolStripMenuItem.Text = "About";
            // 
            // madeByJohnIvanPuayapToolStripMenuItem
            // 
            this.madeByJohnIvanPuayapToolStripMenuItem.Enabled = false;
            this.madeByJohnIvanPuayapToolStripMenuItem.Name = "madeByJohnIvanPuayapToolStripMenuItem";
            this.madeByJohnIvanPuayapToolStripMenuItem.Size = new System.Drawing.Size(475, 26);
            this.madeByJohnIvanPuayapToolStripMenuItem.Text = "Made by John Ivan Puayap for CS345 Intelligent Systems 1";
            this.madeByJohnIvanPuayapToolStripMenuItem.Click += new System.EventHandler(this.madeByJohnIvanPuayapToolStripMenuItem_Click);
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Location = new System.Drawing.Point(259, 548);
            this.lblLoaded.Name = "lblLoaded";
            this.lblLoaded.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoaded.Size = new System.Drawing.Size(94, 16);
            this.lblLoaded.TabIndex = 3;
            this.lblLoaded.Text = "Original Image";
            this.lblLoaded.Visible = false;
            // 
            // lblProcessed
            // 
            this.lblProcessed.AutoSize = true;
            this.lblProcessed.Location = new System.Drawing.Point(838, 548);
            this.lblProcessed.Name = "lblProcessed";
            this.lblProcessed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProcessed.Size = new System.Drawing.Size(114, 16);
            this.lblProcessed.TabIndex = 4;
            this.lblProcessed.Text = "Processed Image";
            this.lblProcessed.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbSubtract1
            // 
            this.pbSubtract1.Location = new System.Drawing.Point(39, 50);
            this.pbSubtract1.Name = "pbSubtract1";
            this.pbSubtract1.Size = new System.Drawing.Size(335, 364);
            this.pbSubtract1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubtract1.TabIndex = 5;
            this.pbSubtract1.TabStop = false;
            // 
            // pbSubtract2
            // 
            this.pbSubtract2.Location = new System.Drawing.Point(409, 50);
            this.pbSubtract2.Name = "pbSubtract2";
            this.pbSubtract2.Size = new System.Drawing.Size(335, 364);
            this.pbSubtract2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubtract2.TabIndex = 6;
            this.pbSubtract2.TabStop = false;
            // 
            // pbSubtractOutput
            // 
            this.pbSubtractOutput.Location = new System.Drawing.Point(786, 50);
            this.pbSubtractOutput.Name = "pbSubtractOutput";
            this.pbSubtractOutput.Size = new System.Drawing.Size(335, 364);
            this.pbSubtractOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSubtractOutput.TabIndex = 7;
            this.pbSubtractOutput.TabStop = false;
            // 
            // pnlSubtract
            // 
            this.pnlSubtract.Controls.Add(this.pbSubtractOutput);
            this.pnlSubtract.Controls.Add(this.pbSubtract2);
            this.pnlSubtract.Controls.Add(this.pbSubtract1);
            this.pnlSubtract.Controls.Add(this.btnSubtract);
            this.pnlSubtract.Controls.Add(this.btnUploadBackground);
            this.pnlSubtract.Controls.Add(this.btnUploadImage);
            this.pnlSubtract.Controls.Add(this.label3);
            this.pnlSubtract.Controls.Add(this.label2);
            this.pnlSubtract.Controls.Add(this.label1);
            this.pnlSubtract.Controls.Add(this.cbCamera);
            this.pnlSubtract.Location = new System.Drawing.Point(3, 31);
            this.pnlSubtract.Name = "pnlSubtract";
            this.pnlSubtract.Size = new System.Drawing.Size(1182, 626);
            this.pnlSubtract.TabIndex = 8;
            this.pnlSubtract.Visible = false;
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubtract.Location = new System.Drawing.Point(882, 464);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(150, 43);
            this.btnSubtract.TabIndex = 16;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnUploadBackground
            // 
            this.btnUploadBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUploadBackground.Location = new System.Drawing.Point(500, 464);
            this.btnUploadBackground.Name = "btnUploadBackground";
            this.btnUploadBackground.Size = new System.Drawing.Size(150, 43);
            this.btnUploadBackground.TabIndex = 15;
            this.btnUploadBackground.Text = "Upload Background";
            this.btnUploadBackground.UseVisualStyleBackColor = true;
            this.btnUploadBackground.Click += new System.EventHandler(this.btnUploadBackground_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(146, 464);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(114, 43);
            this.btnUploadImage.TabIndex = 14;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Background";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(937, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output";
            // 
            // cbCamera
            // 
            this.cbCamera.AutoSize = true;
            this.cbCamera.Location = new System.Drawing.Point(155, 523);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(105, 20);
            this.cbCamera.TabIndex = 10;
            this.cbCamera.Text = "Use Camera";
            this.cbCamera.UseVisualStyleBackColor = true;
            this.cbCamera.CheckedChanged += new System.EventHandler(this.cbCamera_CheckedChanged);
            // 
            // pnlOriginal
            // 
            this.pnlOriginal.Controls.Add(this.pbLoaded);
            this.pnlOriginal.Controls.Add(this.pbProcessed);
            this.pnlOriginal.Controls.Add(this.lblProcessed);
            this.pnlOriginal.Controls.Add(this.lblLoaded);
            this.pnlOriginal.Location = new System.Drawing.Point(0, 31);
            this.pnlOriginal.Name = "pnlOriginal";
            this.pnlOriginal.Size = new System.Drawing.Size(1179, 622);
            this.pnlOriginal.TabIndex = 9;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlSubtract);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlOriginal);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtract2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubtractOutput)).EndInit();
            this.pnlSubtract.ResumeLayout(false);
            this.pnlSubtract.PerformLayout();
            this.pnlOriginal.ResumeLayout(false);
            this.pnlOriginal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoaded;
        private System.Windows.Forms.PictureBox pbProcessed;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activity1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.Label lblLoaded;
        private System.Windows.Forms.Label lblProcessed;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeByJohnIvanPuayapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substractToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbSubtract1;
        private System.Windows.Forms.PictureBox pbSubtract2;
        private System.Windows.Forms.PictureBox pbSubtractOutput;
        private System.Windows.Forms.Panel pnlSubtract;
        private System.Windows.Forms.Panel pnlOriginal;
        private System.Windows.Forms.ToolStripMenuItem useSubtractToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCamera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnUploadBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

