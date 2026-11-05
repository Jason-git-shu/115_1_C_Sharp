namespace String_Compare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 比較按鈕_Click(object sender, EventArgs e)
        {
            string string1,string2;
            string1 = 字串1文字方塊.Text;
            string2 = 字串2文字方塊.Text;

            if (String.Compare(string1, string2) == 0)
            {
                MessageBox.Show("兩個字串相同");
            }
            else if (String.Compare(string1, string2) < 0)
            {
                MessageBox.Show($"{string1} 小於 {string2}");
            }
            else if (String.Compare(string1, string2) > 0)
            {
                MessageBox.Show($"{string1} 大於 {string2}");
            }
            else
            {
                
            }
        }

        private void 離開按鈕_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
