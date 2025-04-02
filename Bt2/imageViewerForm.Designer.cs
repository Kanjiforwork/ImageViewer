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
            this.loadFolderButton = new System.Windows.Forms.Button();
            this.imageFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFolderButton
            // 
            this.loadFolderButton.Location = new System.Drawing.Point(9, 26);
            this.loadFolderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadFolderButton.Name = "loadFolderButton";
            this.loadFolderButton.Size = new System.Drawing.Size(130, 35);
            this.loadFolderButton.TabIndex = 0;
            this.loadFolderButton.Text = "&Load Folder";
            this.loadFolderButton.UseVisualStyleBackColor = true;
            this.loadFolderButton.Click += new System.EventHandler(this.LoadFolderButton_Click);
            // 
            // imageFlowLayoutPanel
            // 
            this.imageFlowLayoutPanel.Location = new System.Drawing.Point(4, 348);
            this.imageFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imageFlowLayoutPanel.Name = "imageFlowLayoutPanel";
            this.imageFlowLayoutPanel.Size = new System.Drawing.Size(764, 130);
            this.imageFlowLayoutPanel.TabIndex = 1;
            this.imageFlowLayoutPanel.WrapContents = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(0, 88);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(899, 254);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
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
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.imageFlowLayoutPanel);
            this.Controls.Add(this.loadFolderButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImageViewerForm";
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFolderButton;
        private System.Windows.Forms.FlowLayoutPanel imageFlowLayoutPanel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label pathLabel;
    }
}
