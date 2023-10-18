namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a=Convert.ToInt32(textBox1.Text);
            b=Convert.ToInt32(textBox2.Text);

            c = a + b;

            label3.Text = Convert.ToString(c);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a - b;

            label3.Text = Convert.ToString(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a * b;

            label3.Text = Convert.ToString(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a / b;

            label3.Text = Convert.ToString(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = a * b;

            label3.Text = Convert.ToString(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            c = (a + b)*2;

            label3.Text = Convert.ToString(c);
        }
    }
}