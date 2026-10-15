using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String
{
    public partial class Form1 : Form
    {
        // Main form constructor. Calls InitializeComponent to
        // create and arrange controls defined in the Designer file.
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "顯示日期" button.
        // This method reads the values entered by the user in the
        // text boxes and displays a formatted birth date string
        // in the output label. The current implementation performs
        // a simple concatenation; input validation can be added if needed.
        private void showDateButton_Click(object sender, EventArgs e)
        {
            // Read values from the input controls
            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string day = dayOfMonthTextBox.Text;
            string year = yearTextBox.Text;

            // Construct the output string and display it.
            // Format: "星期, 月份 日, 年"
            string output = dayOfWeek + ", " + month + " " + day + ", " + year;
            dateOutputLabel.Text = output;
        }

        // Event handler for the "清除" button.
        // Clears all input fields and the output label so the user
        // can enter a new date.
        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = string.Empty; // 星期欄位
            monthTextBox.Text = string.Empty;     // 月份欄位
            dayOfMonthTextBox.Text = string.Empty; // 日欄位
            yearTextBox.Text = string.Empty;      // 年欄位
            dateOutputLabel.Text = string.Empty;  // 顯示欄位

            // Set focus back to the first input for convenience
            dayOfWeekTextBox.Focus();
        }

        // Event handler for the "離開" button.
        // Closes the form. If you prefer to prompt the user for
        // confirmation, you can replace this with a MessageBox.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
