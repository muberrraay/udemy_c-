namespace helloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "mubu";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "mubu";
            label2.Text = "yerinde";
            label7.Text = "yazilim muh.";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "yazilim muh.";
            label8.Text = textBox1.Text;
        }
    }
}