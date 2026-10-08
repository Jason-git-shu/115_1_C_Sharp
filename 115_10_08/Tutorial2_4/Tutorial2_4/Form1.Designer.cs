namespace Tutorial2_4
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
            finlandPictureBox = new PictureBox();
            GermanPictureBox = new PictureBox();
            francePictureBox = new PictureBox();
            countryLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GermanPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).BeginInit();
            SuspendLayout();
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = Properties.Resources.Finland;
            finlandPictureBox.Location = new Point(27, 226);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(318, 157);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            finlandPictureBox.TabIndex = 1;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finlandPictureBox_Click;
            // 
            // GermanPictureBox
            // 
            GermanPictureBox.Image = Properties.Resources.Germany;
            GermanPictureBox.Location = new Point(426, 226);
            GermanPictureBox.Name = "GermanPictureBox";
            GermanPictureBox.Size = new Size(318, 157);
            GermanPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            GermanPictureBox.TabIndex = 2;
            GermanPictureBox.TabStop = false;
            GermanPictureBox.Click += GermanPictureBox_Click;
            // 
            // francePictureBox
            // 
            francePictureBox.Image = Properties.Resources.France;
            francePictureBox.Location = new Point(833, 226);
            francePictureBox.Name = "francePictureBox";
            francePictureBox.Size = new Size(318, 157);
            francePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            francePictureBox.TabIndex = 3;
            francePictureBox.TabStop = false;
            francePictureBox.Click += francePictureBox_Click;
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.Fixed3D;
            countryLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            countryLabel.Location = new Point(426, 497);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(318, 87);
            countryLabel.TabIndex = 4;
            countryLabel.Click += countryLabel_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(229, 56);
            label1.Name = "label1";
            label1.Size = new Size(721, 47);
            label1.TabIndex = 5;
            label1.Text = "點選一個國旗，我告訴你是哪個國家";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 633);
            Controls.Add(label1);
            Controls.Add(countryLabel);
            Controls.Add(francePictureBox);
            Controls.Add(GermanPictureBox);
            Controls.Add(finlandPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GermanPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox finlandPictureBox;
        private PictureBox GermanPictureBox;
        private PictureBox francePictureBox;
        private Label countryLabel;
        private Label label1;
    }
}
