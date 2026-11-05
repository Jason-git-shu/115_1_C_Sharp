using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double km;
            double liters;
            double kmpl;

            if (double.TryParse(kmTextBox.Text, out km))
            {
                if (double.TryParse(literTextBox.Text, out liters))
                {
                    if (liters <= 0)
                    {
                        MessageBox.Show("油量（公升）必須大於零。");
                        return;
                    }
                    if (km < 0)
                    {
                        MessageBox.Show("公里數不能為負數。");
                        return;
                    }
                    kmpl = km / liters;
                    kmplLabel.Text = kmpl.ToString("F2") + " 公里/公升";
                }
                else
                {
                    MessageBox.Show("請輸入有效的油量（公升）數字。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數字。");
            }


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
