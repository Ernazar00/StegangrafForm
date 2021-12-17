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

        static void OpenPicture(PictureBox pictureBox)
        {
            OpenFileDialog openFile = new();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new(openFile.FileName);

                pictureBox.Image = new Bitmap(bitmap, new Size(pictureBox.Width,pictureBox.Height));
            }
        }
        static void OpenText(RichTextBox textBox)
        {
            OpenFileDialog openFile = new();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.Text = System.IO.File.ReadAllText(openFile.FileName).ToLower();
            }
        }
        private void sourcePicture_Click(object sender, EventArgs e)
        {
            OpenPicture(sourcePicture);
        }
        private void messagePicture_Click(object sender, EventArgs e)
        {
            OpenPicture(messagePicture);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (sourcePicture.Image != null )
            {
                Steganografy steganografy = new();

                try
                {
                    if (rImage.Checked && messagePicture.Image != null)
                        resultPicture.Image = steganografy.HideMessage((Bitmap)sourcePicture.Image, (Bitmap)messagePicture.Image);
                    else
                    {
                        resultPicture.Image = steganografy.HideMessage((Bitmap)sourcePicture.Image, messageText.Text, (int)bitSize.Value);
                    }
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
                if (sImage.Checked)
                {
                    hidenPicture.Image = steganografy.ShowMessage((Bitmap)hidedPicture.Image);
                    
                }
                else resultText.Text = steganografy.ShowMessage((Bitmap)hidedPicture.Image, (int)bitSize.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
            }
        }

        void CalcTextSize()
        {
            if(sourcePicture.Image != null)
            {
                int width = sourcePicture.Image.Width;
                int height = sourcePicture.Image.Height;
                int maxSize = (int)bitSize.Value * 3 * width * height / 6;
                textSize.Maximum = maxSize + 1;
                textSize.Value = maxSize;
            }
        }
        private void openSourceBtn_Click(object sender, EventArgs e)
        {
            OpenPicture(sourcePicture);

            CalcTextSize();
        }

        private void openHidden_Click(object sender, EventArgs e)
        {
            if (rImage.Checked)
                OpenPicture(messagePicture);
            else OpenText(messageText);
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

        private void bitSize_ValueChanged(object sender, EventArgs e)
        {
            CalcTextSize();
        }
    }
}
