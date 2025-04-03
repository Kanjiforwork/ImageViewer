namespace BT2
{
    partial class ImageViewerForm
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
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.imgFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(9, 26);
            this.btnLoadFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(130, 35);
            this.btnLoadFolder.TabIndex = 0;
            this.btnLoadFolder.Text = "&Load Folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.LoadFolderButton_Click);
            // 
            // imgFlowLayoutPanel
            // 
            this.imgFlowLayoutPanel.Location = new System.Drawing.Point(4, 348);
            this.imgFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgFlowLayoutPanel.Name = "imgFlowLayoutPanel";
            this.imgFlowLayoutPanel.Size = new System.Drawing.Size(764, 130);
            this.imgFlowLayoutPanel.TabIndex = 1;
            this.imgFlowLayoutPanel.WrapContents = false;
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPictureBox.Location = new System.Drawing.Point(0, 88);
            this.imgPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(899, 254);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 2;
            this.imgPictureBox.TabStop = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(8, 530);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(73, 20);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "                ";
            // 
            // ImageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.imgFlowLayoutPanel);
            this.Controls.Add(this.btnLoadFolder);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImageViewerForm";
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.FlowLayoutPanel imgFlowLayoutPanel;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Label pathLabel;
    }
}
