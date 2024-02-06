using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtBoxNumber1.Text);
                int b = int.Parse(txtBoxNumber2.Text);
                int c = a * b;
                txtResult.Text = c.ToString();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Sorry, the number was too big for this program");
            }
            catch (FormatException ex){
                MessageBox.Show("Sorry the boxes are not in correct format,\n" +
                    "please put only numbers into the boxes");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Sorry! Please try again later");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtBoxNumber1.Text);
                int b = int.Parse(txtBoxNumber2.Text);
                int c = a / b;
                txtResult.Text = c.ToString();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Sorry, the number was too big for this program");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sorry the boxes are not in correct format,\n" +
                    "please put only numbers into the boxes");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Cannot divide by zero yet, sorry we are still working on that technology");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Sorry! Please try again later");
            }
        }
    }
}
