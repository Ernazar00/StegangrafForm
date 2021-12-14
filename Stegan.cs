using System;
using System.Drawing;
using System.Windows.Forms;

namespace SteganForm
{
    public partial class Stegan : Form
    {
        public Stegan()
        {
            InitializeComponent();
        }

        void OpenPicture(PictureBox pictureBox)
        {
            OpenFileDialog openFile = new();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new(openFile.FileName);

                pictureBox.Image = bitmap;
            }
        }
        private void sourcePicture_Click(object sender, EventArgs e)
        {
            OpenPicture(sourcePicture);
        }
        void OpenHiddenPicture()
        {
            OpenFileDialog openFile = new();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new(openFile.FileName);

                messagePicture.Image = bitmap;
            }
        }
        private void messagePicture_Click(object sender, EventArgs e)
        {
            OpenPicture(messagePicture);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (sourcePicture.Image != null && messagePicture.Image != null)
            {
                Steganografy steganografy = new();

                try
                {
                    resultPicture.Image = steganografy.Message((Bitmap)sourcePicture.Image, (Bitmap)messagePicture.Image);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
                }
            }
        }

        private void Recover_Click(object sender, EventArgs e)
        {
            Steganografy steganografy = new();

            try
            {
                hidenPicture.Image = steganografy.HiddenMessage((Bitmap)hidedPicture.Image);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        private void openSourceBtn_Click(object sender, EventArgs e)
        {
            OpenPicture(sourcePicture);
        }

        private void openHidden_Click(object sender, EventArgs e)
        {
            OpenHiddenPicture();
        }

        void SaveResultPicture()
        {
            if(resultPicture.Image != null)
            {
                SaveFileDialog saveFile = new();
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    resultPicture.Image.Save(saveFile.FileName);
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveResultPicture();
        }

        private void openHiddenImage_Click(object sender, EventArgs e)
        {
            OpenPicture(hidedPicture);
        }
    }
}
