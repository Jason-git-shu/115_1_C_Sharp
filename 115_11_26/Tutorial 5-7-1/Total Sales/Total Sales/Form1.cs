using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            try 
            {
                StreamReader inputFile;
                inputFile = File.OpenText("Sales.txt");
                decimal total = 0m;

                openFile.InitialDirectory = "C:\\Users\\m303\\Desktop\\115_1_C_Sharp\\115_11_26\\Tutorial 5-7-1\\Total Sales\\Total Sales\\bin";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFile.FileName;
                    inputFile = File.OpenText(filePath);
                    while (!inputFile.EndOfStream)
                    {
                        if (decimal.TryParse(inputFile.ReadLine(), out decimal sales))
                        {
                            total += sales;
                        }
                        else
                        {
                            MessageBox.Show("檔案中包含無效的銷售額數據。");
                            inputFile.Close();
                            return;
                        }
                    }
                    inputFile.Close();
                    totalLabel.Text = total.ToString("C");
                }

                
            }
            catch 
            {

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
