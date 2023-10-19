namespace WinFormsApp1

{
    public partial class Form1 : Form
    {

        double ilkreqem;
        double ikincireqem;
        string emeliyyat;
        double netice;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonnoqte_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + ",";
                }
            }
        }

        private void buttontoplama_Click(object sender, EventArgs e)
        {
            ilkreqem = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            emeliyyat = "+";
        }

        private void buttoncixma_Click(object sender, EventArgs e)
        {
            ilkreqem = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            emeliyyat = "-";
        }

        private void buttonvurma_Click(object sender, EventArgs e)
        {
            ilkreqem = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            emeliyyat = "*";
        }

        private void buttonbolne_Click(object sender, EventArgs e)
        {
            ilkreqem = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            emeliyyat = "/";
        }

        private void buttonberaber_Click(object sender, EventArgs e)
        {
            ikincireqem = Convert.ToDouble(textBox1.Text);

            if (emeliyyat == "+")
            {
                netice = (ilkreqem + ikincireqem);
                textBox1.Text = Convert.ToString(netice);
                ilkreqem = netice;
            }
            if (emeliyyat == "-")
            {
                netice = (ilkreqem - ikincireqem);
                textBox1.Text = Convert.ToString(netice);
                ilkreqem = netice;
            }
            if (emeliyyat == "*")
            {
                netice = (ilkreqem * ikincireqem);
                textBox1.Text = Convert.ToString(netice);
                ilkreqem = netice;
            }
            if (emeliyyat == "/")
            {
                if (ikincireqem == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    netice = (ilkreqem / ikincireqem);
                    textBox1.Text = Convert.ToString(netice);
                    ilkreqem = netice;
                }
            }
        }
    }
}