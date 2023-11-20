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
            this.lblLoaded = new System.Windows.Forms.Label();
            this.lblProcessed = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLoaded
            // 
            this.pbLoaded.Location = new System.Drawing.Point(56, 48);
            this.pbLoaded.Name = "pbLoaded";
            this.pbLoaded.Size = new System.Drawing.Size(500, 500);
            this.pbLoaded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoaded.TabIndex = 0;
            this.pbLoaded.TabStop = false;
            // 
            // pbProcessed
            // 
            this.pbProcessed.Location = new System.Drawing.Point(605, 48);
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
            this.imageToolStripMenuItem});
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
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // changeFileToolStripMenuItem
            // 
            this.changeFileToolStripMenuItem.Enabled = false;
            this.changeFileToolStripMenuItem.Name = "changeFileToolStripMenuItem";
            this.changeFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.basicCopyToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grayToolStripMenuItem.Text = "Gray Scale";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // inverseImageToolStripMenuItem
            // 
            this.inverseImageToolStripMenuItem.Name = "inverseImageToolStripMenuItem";
            this.inverseImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inverseImageToolStripMenuItem.Text = "Invert";
            this.inverseImageToolStripMenuItem.Click += new System.EventHandler(this.inverseImageToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // lblLoaded
            // 
            this.lblLoaded.AutoSize = true;
            this.lblLoaded.Location = new System.Drawing.Point(225, 563);
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
            this.lblProcessed.Location = new System.Drawing.Point(797, 563);
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
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.lblProcessed);
            this.Controls.Add(this.lblLoaded);
            this.Controls.Add(this.pbProcessed);
            this.Controls.Add(this.pbLoaded);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoaded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProcessed)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

