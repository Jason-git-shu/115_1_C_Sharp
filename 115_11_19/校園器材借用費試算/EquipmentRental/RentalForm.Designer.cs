using System.Drawing;
using System.Windows.Forms;

namespace EquipmentRental
{
    partial class RentalForm
    {
        private Label titleLabel;
        private Label daysCaptionLabel;
        private TextBox daysTextBox;
        private CheckBox clubCheckBox;
        private Button calculateButton;
        private Label feedbackLabel;
        private GroupBox resultGroupBox;
        private Label dailyRateCaptionLabel;
        private Label dailyRateLabel;
        private Label totalCaptionLabel;
        private Label totalLabel;

        private void InitializeComponent()
        {
            titleLabel = new Label();
            daysCaptionLabel = new Label();
            daysTextBox = new TextBox();
            clubCheckBox = new CheckBox();
            calculateButton = new Button();
            feedbackLabel = new Label();
            resultGroupBox = new GroupBox();
            discountLabel = new Label();
            discountCaptionLabel = new Label();
            dailyRateCaptionLabel = new Label();
            dailyRateLabel = new Label();
            totalCaptionLabel = new Label();
            totalLabel = new Label();
            clearButton = new Button();
            resultGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.FromArgb(24, 42, 64);
            titleLabel.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Padding = new Padding(24, 0, 0, 0);
            titleLabel.Size = new Size(520, 78);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "校園器材借用費試算";
            titleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // daysCaptionLabel
            // 
            daysCaptionLabel.AutoSize = true;
            daysCaptionLabel.Location = new Point(27, 107);
            daysCaptionLabel.Name = "daysCaptionLabel";
            daysCaptionLabel.Size = new Size(192, 28);
            daysCaptionLabel.TabIndex = 1;
            daysCaptionLabel.Text = "借用天數（1～7）";
            // 
            // daysTextBox
            // 
            daysTextBox.Location = new Point(256, 104);
            daysTextBox.Name = "daysTextBox";
            daysTextBox.Size = new Size(118, 35);
            daysTextBox.TabIndex = 0;
            // 
            // clubCheckBox
            // 
            clubCheckBox.AutoSize = true;
            clubCheckBox.Location = new Point(256, 147);
            clubCheckBox.Name = "clubCheckBox";
            clubCheckBox.Size = new Size(126, 32);
            clubCheckBox.TabIndex = 1;
            clubCheckBox.Text = "社團借用";
            clubCheckBox.UseVisualStyleBackColor = true;
            clubCheckBox.CheckedChanged += clubCheckBox_CheckedChanged;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.FromArgb(24, 99, 90);
            calculateButton.FlatAppearance.BorderSize = 0;
            calculateButton.FlatStyle = FlatStyle.Flat;
            calculateButton.ForeColor = Color.White;
            calculateButton.Location = new Point(256, 226);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(100, 36);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "試算";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // feedbackLabel
            // 
            feedbackLabel.ForeColor = Color.FromArgb(151, 45, 45);
            feedbackLabel.Location = new Point(27, 230);
            feedbackLabel.Name = "feedbackLabel";
            feedbackLabel.Size = new Size(465, 29);
            feedbackLabel.TabIndex = 3;
            feedbackLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // resultGroupBox
            // 
            resultGroupBox.Controls.Add(discountLabel);
            resultGroupBox.Controls.Add(discountCaptionLabel);
            resultGroupBox.Controls.Add(dailyRateCaptionLabel);
            resultGroupBox.Controls.Add(dailyRateLabel);
            resultGroupBox.Controls.Add(totalCaptionLabel);
            resultGroupBox.Controls.Add(totalLabel);
            resultGroupBox.Location = new Point(24, 271);
            resultGroupBox.Name = "resultGroupBox";
            resultGroupBox.Size = new Size(472, 137);
            resultGroupBox.TabIndex = 4;
            resultGroupBox.TabStop = false;
            resultGroupBox.Text = "試算結果";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new Point(166, 65);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new Size(36, 28);
            discountLabel.TabIndex = 5;
            discountLabel.Text = "—";
            // 
            // discountCaptionLabel
            // 
            discountCaptionLabel.AutoSize = true;
            discountCaptionLabel.Location = new Point(18, 65);
            discountCaptionLabel.Name = "discountCaptionLabel";
            discountCaptionLabel.Size = new Size(100, 28);
            discountCaptionLabel.TabIndex = 4;
            discountCaptionLabel.Text = "優惠狀態";
            discountCaptionLabel.Click += discountCaptionLabel_Click;
            // 
            // dailyRateCaptionLabel
            // 
            dailyRateCaptionLabel.AutoSize = true;
            dailyRateCaptionLabel.Location = new Point(18, 33);
            dailyRateCaptionLabel.Name = "dailyRateCaptionLabel";
            dailyRateCaptionLabel.Size = new Size(100, 28);
            dailyRateCaptionLabel.TabIndex = 0;
            dailyRateCaptionLabel.Text = "每日費用";
            dailyRateCaptionLabel.Click += dailyRateCaptionLabel_Click;
            // 
            // dailyRateLabel
            // 
            dailyRateLabel.AutoSize = true;
            dailyRateLabel.Location = new Point(166, 33);
            dailyRateLabel.Name = "dailyRateLabel";
            dailyRateLabel.Size = new Size(36, 28);
            dailyRateLabel.TabIndex = 1;
            dailyRateLabel.Text = "—";
            // 
            // totalCaptionLabel
            // 
            totalCaptionLabel.AutoSize = true;
            totalCaptionLabel.Location = new Point(18, 99);
            totalCaptionLabel.Name = "totalCaptionLabel";
            totalCaptionLabel.Size = new Size(100, 28);
            totalCaptionLabel.TabIndex = 2;
            totalCaptionLabel.Text = "應付金額";
            totalCaptionLabel.Click += totalCaptionLabel_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Microsoft JhengHei UI", 13F, FontStyle.Bold);
            totalLabel.ForeColor = Color.FromArgb(24, 99, 90);
            totalLabel.Location = new Point(166, 96);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(43, 33);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "—";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(256, 185);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 34);
            clearButton.TabIndex = 5;
            clearButton.Text = "清除";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // RentalForm
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(520, 430);
            Controls.Add(clearButton);
            Controls.Add(titleLabel);
            Controls.Add(daysCaptionLabel);
            Controls.Add(daysTextBox);
            Controls.Add(clubCheckBox);
            Controls.Add(calculateButton);
            Controls.Add(feedbackLabel);
            Controls.Add(resultGroupBox);
            Font = new Font("Microsoft JhengHei UI", 11F);
            ForeColor = Color.FromArgb(24, 42, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RentalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "校園器材借用費試算";
            resultGroupBox.ResumeLayout(false);
            resultGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label discountCaptionLabel;
        private Label discountLabel;
        private Button clearButton;
    }
}
