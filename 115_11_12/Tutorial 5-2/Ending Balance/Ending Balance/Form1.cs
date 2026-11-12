using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   
            const decimal rate = 0.005m; // Interest rate of 0.5%
            decimal balance; // To hold the starting balance
            int months; // To hold the number of months
            int count = 1; // Loop counter

            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    count = 1;
                    while (count <= months)
                    {
                       balance = balance * (1 + 0.005m); // Calculate the new balance
                        detailListBox.Items.Add($"第 {count}個月的本利和 {balance:C2}"); // Display the balance for the current month
                        count++;
                    }
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的月分和數量");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
