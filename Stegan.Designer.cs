
namespace SteganForm
{
    partial class Stegan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePicture = new System.Windows.Forms.PictureBox();
            this.messagePicture = new System.Windows.Forms.PictureBox();
            this.resultPicture = new System.Windows.Forms.PictureBox();
            this.hidenPicture = new System.Windows.Forms.PictureBox();
            this.hideButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bitSize = new System.Windows.Forms.NumericUpDown();
            this.rText = new System.Windows.Forms.RadioButton();
            this.rImage = new System.Windows.Forms.RadioButton();
            this.messageText = new System.Windows.Forms.RichTextBox();
            this.openHidden = new System.Windows.Forms.Button();
            this.openSourceBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openHiddenImage = new System.Windows.Forms.Button();
            this.hidedPicture = new System.Windows.Forms.PictureBox();
            this.Recover = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.sText = new System.Windows.Forms.RadioButton();
            this.sImage = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidenPicture)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitSize)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePicture
            // 
            this.sourcePicture.Location = new System.Drawing.Point(6, 6);
            this.sourcePicture.Name = "sourcePicture";
            this.sourcePicture.Size = new System.Drawing.Size(417, 405);
            this.sourcePicture.TabIndex = 0;
            this.sourcePicture.TabStop = false;
            this.sourcePicture.Click += new System.EventHandler(this.sourcePicture_Click);
            // 
            // messagePicture
            // 
            this.messagePicture.Location = new System.Drawing.Point(429, 6);
            this.messagePicture.Name = "messagePicture";
            this.messagePicture.Size = new System.Drawing.Size(379, 229);
            this.messagePicture.TabIndex = 1;
            this.messagePicture.TabStop = false;
            this.messagePicture.Click += new System.EventHandler(this.messagePicture_Click);
            // 
            // resultPicture
            // 
            this.resultPicture.Location = new System.Drawing.Point(814, 6);
            this.resultPicture.Name = "resultPicture";
            this.resultPicture.Size = new System.Drawing.Size(426, 405);
            this.resultPicture.TabIndex = 2;
            this.resultPicture.TabStop = false;
            // 
            // hidenPicture
            // 
            this.hidenPicture.Location = new System.Drawing.Point(493, 17);
            this.hidenPicture.Name = "hidenPicture";
            this.hidenPicture.Size = new System.Drawing.Size(403, 345);
            this.hidenPicture.TabIndex = 3;
            this.hidenPicture.TabStop = false;
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(814, 422);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 4;
            this.hideButton.Text = "Скрыть";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1151, 422);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 507);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textSize);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bitSize);
            this.tabPage1.Controls.Add(this.rText);
            this.tabPage1.Controls.Add(this.rImage);
            this.tabPage1.Controls.Add(this.messageText);
            this.tabPage1.Controls.Add(this.openHidden);
            this.tabPage1.Controls.Add(this.openSourceBtn);
            this.tabPage1.Controls.Add(this.messagePicture);
            this.tabPage1.Controls.Add(this.saveButton);
            this.tabPage1.Controls.Add(this.sourcePicture);
            this.tabPage1.Controls.Add(this.hideButton);
            this.tabPage1.Controls.Add(this.resultPicture);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скрытие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Вместимость символов в изображении";
            // 
            // textSize
            // 
            this.textSize.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textSize.Location = new System.Drawing.Point(241, 451);
            this.textSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.textSize.Name = "textSize";
            this.textSize.Size = new System.Drawing.Size(79, 23);
            this.textSize.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Количество битов на канал";
            // 
            // bitSize
            // 
            this.bitSize.Location = new System.Drawing.Point(241, 421);
            this.bitSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.bitSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitSize.Name = "bitSize";
            this.bitSize.Size = new System.Drawing.Size(79, 23);
            this.bitSize.TabIndex = 11;
            this.bitSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bitSize.ValueChanged += new System.EventHandler(this.bitSize_ValueChanged);
            // 
            // rText
            // 
            this.rText.AutoSize = true;
            this.rText.Checked = true;
            this.rText.Location = new System.Drawing.Point(559, 425);
            this.rText.Name = "rText";
            this.rText.Size = new System.Drawing.Size(54, 19);
            this.rText.TabIndex = 10;
            this.rText.TabStop = true;
            this.rText.Text = "Текст";
            this.rText.UseVisualStyleBackColor = true;
            // 
            // rImage
            // 
            this.rImage.AutoSize = true;
            this.rImage.Location = new System.Drawing.Point(446, 425);
            this.rImage.Name = "rImage";
            this.rImage.Size = new System.Drawing.Size(101, 19);
            this.rImage.TabIndex = 9;
            this.rImage.TabStop = true;
            this.rImage.Text = "Изображение";
            this.rImage.UseVisualStyleBackColor = true;
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(429, 241);
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(379, 170);
            this.messageText.TabIndex = 8;
            this.messageText.Text = "";
            // 
            // openHidden
            // 
            this.openHidden.Location = new System.Drawing.Point(733, 422);
            this.openHidden.Name = "openHidden";
            this.openHidden.Size = new System.Drawing.Size(75, 23);
            this.openHidden.TabIndex = 7;
            this.openHidden.Text = "Открыть";
            this.openHidden.UseVisualStyleBackColor = true;
            this.openHidden.Click += new System.EventHandler(this.openHidden_Click);
            // 
            // openSourceBtn
            // 
            this.openSourceBtn.Location = new System.Drawing.Point(348, 422);
            this.openSourceBtn.Name = "openSourceBtn";
            this.openSourceBtn.Size = new System.Drawing.Size(75, 23);
            this.openSourceBtn.TabIndex = 6;
            this.openSourceBtn.Text = "Открыть";
            this.openSourceBtn.UseVisualStyleBackColor = true;
            this.openSourceBtn.Click += new System.EventHandler(this.openSourceBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sText);
            this.tabPage2.Controls.Add(this.sImage);
            this.tabPage2.Controls.Add(this.resultText);
            this.tabPage2.Controls.Add(this.openHiddenImage);
            this.tabPage2.Controls.Add(this.hidedPicture);
            this.tabPage2.Controls.Add(this.Recover);
            this.tabPage2.Controls.Add(this.hidenPicture);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Раскрытие";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openHiddenImage
            // 
            this.openHiddenImage.Location = new System.Drawing.Point(392, 368);
            this.openHiddenImage.Name = "openHiddenImage";
            this.openHiddenImage.Size = new System.Drawing.Size(75, 23);
            this.openHiddenImage.TabIndex = 6;
            this.openHiddenImage.Text = "Открыть";
            this.openHiddenImage.UseVisualStyleBackColor = true;
            this.openHiddenImage.Click += new System.EventHandler(this.openHiddenImage_Click);
            // 
            // hidedPicture
            // 
            this.hidedPicture.Location = new System.Drawing.Point(31, 17);
            this.hidedPicture.Name = "hidedPicture";
            this.hidedPicture.Size = new System.Drawing.Size(436, 345);
            this.hidedPicture.TabIndex = 5;
            this.hidedPicture.TabStop = false;
            // 
            // Recover
            // 
            this.Recover.Location = new System.Drawing.Point(821, 368);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(75, 23);
            this.Recover.TabIndex = 4;
            this.Recover.Text = "Раскрыть";
            this.Recover.UseVisualStyleBackColor = true;
            this.Recover.Click += new System.EventHandler(this.Recover_Click);
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(916, 17);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(324, 345);
            this.resultText.TabIndex = 7;
            this.resultText.Text = "";
            // 
            // sText
            // 
            this.sText.AutoSize = true;
            this.sText.Checked = true;
            this.sText.Location = new System.Drawing.Point(678, 372);
            this.sText.Name = "sText";
            this.sText.Size = new System.Drawing.Size(54, 19);
            this.sText.TabIndex = 12;
            this.sText.TabStop = true;
            this.sText.Text = "Текст";
            this.sText.UseVisualStyleBackColor = true;
            // 
            // sImage
            // 
            this.sImage.AutoSize = true;
            this.sImage.Location = new System.Drawing.Point(565, 372);
            this.sImage.Name = "sImage";
            this.sImage.Size = new System.Drawing.Size(101, 19);
            this.sImage.TabIndex = 11;
            this.sImage.TabStop = true;
            this.sImage.Text = "Изображение";
            this.sImage.UseVisualStyleBackColor = true;
            // 
            // Stegan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 514);
            this.Controls.Add(this.tabControl1);
            this.Name = "Stegan";
            this.Text = "Steganograf";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidenPicture)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitSize)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidedPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePicture;
        private System.Windows.Forms.PictureBox messagePicture;
        private System.Windows.Forms.PictureBox resultPicture;
        private System.Windows.Forms.PictureBox hidenPicture;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Recover;
        private System.Windows.Forms.PictureBox hidedPicture;
        private System.Windows.Forms.Button openHidden;
        private System.Windows.Forms.Button openSourceBtn;
        private System.Windows.Forms.Button openHiddenImage;
        private System.Windows.Forms.RichTextBox messageText;
        private System.Windows.Forms.RadioButton rText;
        private System.Windows.Forms.RadioButton rImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown textSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown bitSize;
        private System.Windows.Forms.RadioButton sText;
        private System.Windows.Forms.RadioButton sImage;
        private System.Windows.Forms.RichTextBox resultText;
    }
}

