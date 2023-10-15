namespace Calculator
{
    public partial class Form1 : Form
    {
        public float a, result;
        public string operand;

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 9)
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operand = "/";
                }
                else
                {
                    MessageBox.Show("Число слишком большое");
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 9)
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operand = "*";
                }
                else
                {
                    MessageBox.Show("Число слишком большое");
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 9)
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operand = "-";
                }
                else
                {
                    MessageBox.Show("Число слишком большое");
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length <= 9)
                {
                    a = float.Parse(textBox1.Text);
                    textBox1.Clear();
                    operand = "+";
                }
                else
                {
                    MessageBox.Show("Число слишком большое");
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                switch (operand)
                {
                    case "/":

                        if (float.Parse(textBox1.Text) != 0)
                        {
                            result = a / float.Parse(textBox1.Text);
                            textBox1.Text = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("На ноль делить нельзя");
                        }

                        break;

                    case "*":
                        result = a * float.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        break;

                    case "-":
                        result = a - float.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        break;

                    case "+":
                        result = a + float.Parse(textBox1.Text);
                        textBox1.Text = result.ToString();
                        break;

                    default:
                        MessageBox.Show("Вы не ввели число или операнд");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand = textBox1.Text = "";
            a = result = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                float op;
                op = float.Parse(textBox1.Text);
                op = -op;
                textBox1.Text = op.ToString();
            }
            catch
            {
                MessageBox.Show("Вы не ввели число");
            }
        }
    }
}