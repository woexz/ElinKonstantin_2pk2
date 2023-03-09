using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pz_calculator_Systems_MDK
{
    public partial class Form1 : Form
    {
        public static double result;
        public static char action;
        public static char position;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button6.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (position == '=')
            {
                textBox1.Text = null;
                position = 'n';
            }
            textBox1.Text += button10.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {            
            if (textBox1.Text != null)
            {
                result = double.Parse(textBox1.Text);
                textBox1.Text = null;
                action = Convert.ToChar(buttonPlus.Text);
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && action == '+')
            {
                result += double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            else if(textBox1.Text != null && action == '-')
            {
                result -= double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            else if (textBox1.Text != null && action == '*')
            {
                result *= double.Parse(textBox1.Text);
                textBox1.Text = Convert.ToString(result);
            }
            else if (textBox1.Text != null && action == '√')
            {
                textBox1.Text = Convert.ToString(result);
            }
            else if (textBox1.Text != null && action == '^')
            {
                result = Math.Pow(result, 2);
                textBox1.Text = Convert.ToString(result);
            }
            position = '=';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                result = double.Parse(textBox1.Text);
                textBox1.Text = null;
                action = Convert.ToChar(buttonMinus.Text);
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                result = double.Parse(textBox1.Text);
                textBox1.Text = null;
                action = Convert.ToChar(buttonMultiply.Text);
            }
        }

        private void delete(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                result = double.Parse(textBox1.Text);
                textBox1.Text = null;
                action = '^';
            }
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                result = Math.Sqrt(Convert.ToDouble(textBox1.Text));
                textBox1.Text = null;
                action = Convert.ToChar(Sqrt.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
