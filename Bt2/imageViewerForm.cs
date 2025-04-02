using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BT2
{
    public partial class ImageViewerForm : Form
    {
        public ImageViewerForm()
        {
            InitializeComponent();
        }

        private void LoadFolderButton_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImagesFromFolder(dialog.SelectedPath);
                }
            }
        }
        private void LoadImagesFromFolder(string folderPath)
        {
            var imageFiles = Directory.EnumerateFiles(folderPath)
                                      .Where(file => file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".png", StringComparison.OrdinalIgnoreCase));

            imageFlowLayoutPanel.Controls.Clear();

            foreach (var file in imageFiles)
            {
                var pictureBox = CreatePictureBox(file);
                imageFlowLayoutPanel.Controls.Add(pictureBox);
            }
        }

        private PictureBox CreatePictureBox(string imagePath)
        {
            var pictureBox = new PictureBox
            {
                Cursor = Cursors.Hand,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 150,
                Height = 100,
                Tag = imagePath
            };

            pictureBox.Load(imagePath);
            pictureBox.Click += PictureBox_Click;

            return pictureBox;
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox && pictureBox.Tag is string imgPath)
            {
                imagePictureBox.Load(imgPath);
                imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pathLabel.Text = $"File: {imgPath} is loaded.";
            }
        }
    }
}
