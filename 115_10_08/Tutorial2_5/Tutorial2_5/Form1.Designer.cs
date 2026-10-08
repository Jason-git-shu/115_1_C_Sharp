namespace Tutorial2_5
{
    partial class Form1
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
            cardBackPictureBox = new PictureBox();
            cardFacePictureBox = new PictureBox();
            showBackButton = new Button();
            showFaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardBackPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardBackPictureBox
            // 
            cardBackPictureBox.Image = Properties.Resources.Backface_Blue;
            cardBackPictureBox.Location = new Point(322, 75);
            cardBackPictureBox.Name = "cardBackPictureBox";
            cardBackPictureBox.Size = new Size(164, 245);
            cardBackPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBackPictureBox.TabIndex = 0;
            cardBackPictureBox.TabStop = false;
            cardBackPictureBox.Visible = false;
            // 
            // cardFacePictureBox
            // 
            cardFacePictureBox.Image = Properties.Resources.King_Hearts;
            cardFacePictureBox.Location = new Point(322, 75);
            cardFacePictureBox.Name = "cardFacePictureBox";
            cardFacePictureBox.Size = new Size(164, 245);
            cardFacePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFacePictureBox.TabIndex = 1;
            cardFacePictureBox.TabStop = false;
            // 
            // showBackButton
            // 
            showBackButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showBackButton.Location = new Point(104, 362);
            showBackButton.Name = "showBackButton";
            showBackButton.Size = new Size(164, 51);
            showBackButton.TabIndex = 2;
            showBackButton.Text = "顯示背面";
            showBackButton.UseVisualStyleBackColor = true;
            showBackButton.Click += showBackButton_Click;
            // 
            // showFaceButton
            // 
            showFaceButton.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            showFaceButton.Location = new Point(556, 362);
            showFaceButton.Name = "showFaceButton";
            showFaceButton.Size = new Size(164, 51);
            showFaceButton.TabIndex = 3;
            showFaceButton.Text = "顯示正面";
            showFaceButton.UseVisualStyleBackColor = true;
            showFaceButton.Click += showFaceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showFaceButton);
            Controls.Add(showBackButton);
            Controls.Add(cardFacePictureBox);
            Controls.Add(cardBackPictureBox);
            Name = "Form1";
            Text = "撲克牌展示";
            ((System.ComponentModel.ISupportInitialize)cardBackPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardFacePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardBackPictureBox;
        private PictureBox cardFacePictureBox;
        private Button showBackButton;
        private Button showFaceButton;
    }
}
