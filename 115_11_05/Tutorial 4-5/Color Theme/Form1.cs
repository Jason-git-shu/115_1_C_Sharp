using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Theme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 黃色選項的背景色彩處理保留給教學範例使用。
        }

        private void redRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 紅色選項的背景色彩處理保留給教學範例使用。
        }

        private void whiteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 白色選項的背景色彩處理保留給教學範例使用。
        }

        private void normalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // 恢復正常選項的背景色彩處理保留給教學範例使用。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
