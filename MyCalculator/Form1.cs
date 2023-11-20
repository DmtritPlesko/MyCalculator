using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    
    public partial class Form1 : Form
    {
        public string Arg1;
        public string Arg2;
        public char sign=' ';
        public Form1()
        {
            InitializeComponent();
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            if(sign!=' ')
            {
                Arg2 += 1;
                textBox1.Text = Arg2;
            }
            else
            {
                Arg1 += 1;
                textBox1.Text = Arg1;
            }
        }

        private void Number2_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 2;
                textBox1.Text = Arg2;
            }
            else
            {
                Arg1 += 2;
                textBox1.Text = Arg1;
            }
        }

        private void Number3_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 3;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 3;
                textBox1.Text = Arg1;

            }
        }

        private void Number4_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 4;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 4;
                textBox1.Text = Arg1;

            }
        }

        private void Number5_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 5;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 5;
                textBox1.Text = Arg1;

            }
        }

        private void Number6_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 6;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 6;
                textBox1.Text = Arg1;

            }
        }

        private void Number7_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 7;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 7;
                textBox1.Text = Arg1;

            }
        }

        private void Number8_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 8;
                textBox1.Text = Arg2;

            }
            else 
            {
                Arg1 += 8;
                textBox1.Text = Arg1;

            }
        }

        private void Number9_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 9;
                textBox1.Text = Arg2;

            }
            else
            {
                Arg1 += 9;
                textBox1.Text = Arg1;

            }
        }

        private void Number0_Click(object sender, EventArgs e)
        {
            if (sign != ' ')
            {
                Arg2 += 0;
                textBox1.Text = Arg2;

            }
            else 
            {
                Arg1 += 0;
                textBox1.Text = Arg1;

            }
        }

        private void BT_Clear_Click(object sender, EventArgs e)
        {
            Arg2 = "";
            Arg1 = "";
            sign = ' ';
            textBox1.Clear();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            sign = '+';
            textBox1.Clear();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            sign='-';
            textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            sign = '*';
            textBox1.Clear();
        }

        private void Share_Click(object sender, EventArgs e)
        {
            sign = '/';
            textBox1.Clear();
        }

        private void equally_Click(object sender, EventArgs e)
        {
            double arg1 = Convert.ToDouble(Arg1);
            double arg2 = Convert.ToDouble(Arg2);
            if(arg1==null)
            {
                arg1 = 0;
            }
            if(arg2 == null)
            {
                arg2 = 0;
            }
            double rez=0;
            switch (sign)
            {
                case '+':
                    {
                        rez = arg1 + arg2;
                        break;
                    }
                case '-':
                    {
                        rez = arg1 - arg2;
                        break;
                    }
                case '*':
                    {
                        rez = arg1 * arg2;
                        break;
                    }
                case '/':
                    {
                        if (arg1 == null)
                        {
                            arg1 = 1;
                        }
                        if (arg2 == null)
                        {
                            arg2 = 1;
                        }
                        rez = arg1 / arg2;
                        break;
                    }
            }
            textBox1.Text = Arg1 + sign + Arg2 + " = " + rez;

        }
    }
}
