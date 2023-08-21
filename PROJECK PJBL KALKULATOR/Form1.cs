using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECK_PJBL_KALKULATOR
{
    public partial class Form1 : Form
    {
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "1";
            }
            else
            {
                {
                    textBox2.Text += "1";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "2";
            }
            else
            {
                textBox2.Text += "2";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "3";
            }
            else
            {
                textBox2.Text += "3";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "4";
            }
            else
            {
                textBox2.Text += "4";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "5";
            }
            else
            {
                textBox2.Text += "5";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "6";
            }
            else
            {
                textBox2.Text += "6";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "7";
            }
            else
            {
                textBox2.Text += "7";
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "8";
            }
            else
            {
                textBox2.Text += "8";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = "9";
            }
            else
            {
                textBox2.Text += "9";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                textBox2.Text += "0";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            bil1 = 0;
            bil2 = 0;
            textBox3.Text   = " ";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox2.Text);
            textBox3.Text = "×";
            textBox2.Text = " ";
            opr = 1;
            opr_selesai = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox2.Text);
            textBox3.Text = "÷";
            textBox2.Text = " ";
            opr = 2;
            opr_selesai = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox2.Text);
            textBox3.Text = "-";
            textBox2.Text = " ";
            opr = 3;
            opr_selesai = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(textBox2.Text);
            textBox3.Text = "+";
            textBox2.Text = " ";
            opr = 4;
            opr_selesai = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(textBox2.Text);
            {
                switch (opr)
                {
                    case 1:
                        textBox2.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        textBox2.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        textBox2.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        textBox2.Text = Convert.ToString(bil1 + bil2);
                        break;

                }
                opr_selesai = false;
            }
        }
    }
}