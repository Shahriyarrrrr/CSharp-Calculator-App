namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        private double num1, num2, result;
        private char optl;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void btnaddition_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            optl = '+';
            label1.Text = num1 + "+";
            richTextBox1.Text = "";
        }

        private void btnsubtraction_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            optl = '-';
            label1.Text = num1 + "-";
            richTextBox1.Text = "";
        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            optl = '*';
            label1.Text = num1 + "*";
            richTextBox1.Text = "";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(richTextBox1.Text);
            optl = '/';
            label1.Text = num1 + "/";
            richTextBox1.Text = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(richTextBox1.Text);
            if (optl == '+')
            {
                result = num1 + num2;
            }
            else if (optl == '-')
            {
                result = num1 - num2;
            }
            else if (optl == '*')
            {
                result = num1 * num2;
            }
            else if (optl == '/')
            {
                result = num1 / num2;
            }
            richTextBox1.Text = result.ToString();
            label1.Text = num1.ToString() + optl.ToString() + num2.ToString() + "=";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ".";
        }
    }
}
