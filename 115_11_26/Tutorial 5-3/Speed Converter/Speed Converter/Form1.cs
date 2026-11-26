using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Speed_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 建立並初始化表單元件。
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            // 設定速度範圍、間隔及公里換算成英里的係數。
            const int START_SPEED = 60;
            const int END_SPEED = 130;
            const int INTERVAL = 10;
            const double CONVERSION_FACTOR = 0.6214;

            // 清除先前的結果，避免重複顯示。
            outputListBox.Items.Clear();

            // 將每個公里時速換算成英里時速並顯示在清單中。
            for (int speed = START_SPEED; speed <= END_SPEED; speed += INTERVAL)
            {
                double convertedSpeed = speed * CONVERSION_FACTOR;
                outputListBox.Items.Add(
                    string.Format("{0} 公里／小時 = {1:F2} 英里／小時", speed, convertedSpeed));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}