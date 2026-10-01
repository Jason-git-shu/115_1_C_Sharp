namespace Tutorial2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Guten Morgen";
        }

        private void ltalianButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buongiorno";
        }

        private void spanlishButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = "Buen dia";
        }
    }
}
