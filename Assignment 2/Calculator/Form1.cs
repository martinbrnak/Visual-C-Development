using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool isClear = true;
        string last = "";
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "1";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "2";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "3";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "4";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "5";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "6";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "7";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "8";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "9";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = "0";
                isClear = false;
            }
            else
            {
                txtNumber.Text += "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (isClear)
            {
                txtNumber.Text = ".";
                isClear = false;
            }
            else
            {
                txtNumber.Text += ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            last = txtNumber.Text;
            isClear = true;
            operation = "+";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            last = txtNumber.Text;
            isClear = true;
            operation = "*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            last = txtNumber.Text;
            isClear = true;
            operation = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            last = txtNumber.Text;
            isClear = true;
            operation = "/";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
            isClear = true;
            last = "";
            operation = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtNumber.Text = process_calculation(operation, last, txtNumber.Text).ToString();
            isClear = true;
        }

        private float process_calculation(string operand, string before, string current)
        {
            try
            {
                float ret = float.Parse(before);
                float second = float.Parse(current);



                if (operand.Equals("+"))
                {
                    ret += second;
                }
                else if (operand.Equals("-"))
                {
                    ret -= second;
                }
                else if (operand.Equals("*"))
                {
                    ret *= second;
                }
                else if (operand.Equals("/"))
                {
                    ret /= second;
                }
                return ret;
            }
            catch
            {
                try
                {
                    return float.Parse(current);
                }
                catch 
                { 
                    return 0;
                }
            }
        }
    }
}
