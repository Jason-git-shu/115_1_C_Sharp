using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city;
            if  (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                switch (city)
                {
                    case "丹佛":
                        timeZoneLabel.Text = "Mountain Time";
                        break;
                    case "檀香山":
                        timeZoneLabel.Text = "Hawaii-Aleutian Time";
                        break;
                    case "明尼阿波利斯":
                        timeZoneLabel.Text = "Central Time";
                        break;
                    case "紐約":
                        timeZoneLabel.Text = "Eastern Time";
                        break;
                    case "舊金山":
                        timeZoneLabel.Text = "Pacific Time";
                        break;
                }
            }
            else
            {
                MessageBox.Show("請選擇一個城市。", "錯誤");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void cityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
