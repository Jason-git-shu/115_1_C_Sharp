namespace Tutorial2_3
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
            label1 = new Label();
            translateLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(151, 105);
            label1.Name = "label1";
            label1.Size = new Size(400, 128);
            label1.TabIndex = 0;
            label1.Text = "請選擇一種語言，我告訴你怎麼說\"早安\"";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // translateLabel
            // 
            translateLabel.BorderStyle = BorderStyle.FixedSingle;
            translateLabel.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            translateLabel.Location = new Point(328, 325);
            translateLabel.Name = "translateLabel";
            translateLabel.Size = new Size(92, 34);
            translateLabel.TabIndex = 1;
            translateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(translateLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label translateLabel;
    }
}
