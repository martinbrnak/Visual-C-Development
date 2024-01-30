using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtWarning.Text = "";
                double c = Double.Parse(txtCelsius.Text);
                double f = CelsiusToFahrenheit(c);
                txtFahrenheit.Text = f.ToString();
            }
            catch
            {
                txtWarning.Text = "Incorrect input";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public double CelsiusToFahrenheit(double c)
        {

            return c * (9/5.0) + 32;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtWarning.Text = "";
                double c = Double.Parse(txtCelsius.Text);
                double f = CelsiusToFahrenheit(c);
                txtFahrenheit.Text = f.ToString();
            }
            catch
            {
                txtWarning.Text = "Incorrect input";
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtCelsius.Text = trackbarCels.Value.ToString();
        }
    }
}
