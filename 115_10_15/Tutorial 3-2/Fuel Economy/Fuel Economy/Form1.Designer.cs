namespace Fuel_Economy
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
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.kmTextBox = new System.Windows.Forms.TextBox();
            this.literTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.kmplLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(14, 21);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(170, 18);
            this.milesPromptLabel.TabIndex = 0;
            this.milesPromptLabel.Text = "輸入行駛的公里數：";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(14, 66);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(224, 18);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "輸入使用的油量（公升）：";
            // 
            // kmTextBox
            // 
            this.kmTextBox.Location = new System.Drawing.Point(264, 17);
            this.kmTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.kmTextBox.Name = "kmTextBox";
            this.kmTextBox.Size = new System.Drawing.Size(148, 29);
            this.kmTextBox.TabIndex = 2;
            // 
            // literTextBox
            // 
            this.literTextBox.Location = new System.Drawing.Point(264, 55);
            this.literTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.literTextBox.Name = "literTextBox";
            this.literTextBox.Size = new System.Drawing.Size(148, 29);
            this.literTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(14, 115);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(224, 18);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "您車輛的每百公里耗油量：";
            // 
            // kmplLabel
            // 
            this.kmplLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kmplLabel.Location = new System.Drawing.Point(264, 109);
            this.kmplLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kmplLabel.Name = "kmplLabel";
            this.kmplLabel.Size = new System.Drawing.Size(149, 31);
            this.kmplLabel.TabIndex = 5;
            this.kmplLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(96, 186);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(112, 48);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算耗油量";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(218, 186);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 48);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 251);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.kmplLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.literTextBox);
            this.Controls.Add(this.kmTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "燃油經濟性";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.TextBox kmTextBox;
        private System.Windows.Forms.TextBox literTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label kmplLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

