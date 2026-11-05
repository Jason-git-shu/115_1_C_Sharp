namespace String_Compare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label 字串1標籤;
        private Label 字串2標籤;
        private TextBox 字串1文字方塊;
        private TextBox 字串2文字方塊;
        private Button 比較按鈕;
        private Button 離開按鈕;

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
            字串1標籤 = new Label();
            字串2標籤 = new Label();
            字串1文字方塊 = new TextBox();
            字串2文字方塊 = new TextBox();
            比較按鈕 = new Button();
            離開按鈕 = new Button();
            SuspendLayout();
            // 
            // 字串1標籤
            // 
            字串1標籤.AutoSize = true;
            字串1標籤.Location = new Point(126, 100);
            字串1標籤.Margin = new Padding(5, 0, 5, 0);
            字串1標籤.Name = "字串1標籤";
            字串1標籤.Size = new Size(74, 23);
            字串1標籤.TabIndex = 0;
            字串1標籤.Text = "字串1：";
            // 
            // 字串2標籤
            // 
            字串2標籤.AutoSize = true;
            字串2標籤.Location = new Point(126, 192);
            字串2標籤.Margin = new Padding(5, 0, 5, 0);
            字串2標籤.Name = "字串2標籤";
            字串2標籤.Size = new Size(74, 23);
            字串2標籤.TabIndex = 1;
            字串2標籤.Text = "字串2：";
            // 
            // 字串1文字方塊
            // 
            字串1文字方塊.Location = new Point(251, 92);
            字串1文字方塊.Margin = new Padding(5, 5, 5, 5);
            字串1文字方塊.Name = "字串1文字方塊";
            字串1文字方塊.Size = new Size(626, 30);
            字串1文字方塊.TabIndex = 2;
            // 
            // 字串2文字方塊
            // 
            字串2文字方塊.Location = new Point(251, 184);
            字串2文字方塊.Margin = new Padding(5, 5, 5, 5);
            字串2文字方塊.Name = "字串2文字方塊";
            字串2文字方塊.Size = new Size(626, 30);
            字串2文字方塊.TabIndex = 3;
            // 
            // 比較按鈕
            // 
            比較按鈕.Location = new Point(283, 291);
            比較按鈕.Margin = new Padding(5, 5, 5, 5);
            比較按鈕.Name = "比較按鈕";
            比較按鈕.Size = new Size(157, 54);
            比較按鈕.TabIndex = 4;
            比較按鈕.Text = "比較";
            比較按鈕.UseVisualStyleBackColor = true;
            比較按鈕.Click += 比較按鈕_Click;
            // 
            // 離開按鈕
            // 
            離開按鈕.Location = new Point(629, 291);
            離開按鈕.Margin = new Padding(5, 5, 5, 5);
            離開按鈕.Name = "離開按鈕";
            離開按鈕.Size = new Size(157, 54);
            離開按鈕.TabIndex = 5;
            離開按鈕.Text = "離開";
            離開按鈕.UseVisualStyleBackColor = true;
            離開按鈕.Click += 離開按鈕_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 460);
            Controls.Add(離開按鈕);
            Controls.Add(比較按鈕);
            Controls.Add(字串2文字方塊);
            Controls.Add(字串1文字方塊);
            Controls.Add(字串2標籤);
            Controls.Add(字串1標籤);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "字串比較";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
