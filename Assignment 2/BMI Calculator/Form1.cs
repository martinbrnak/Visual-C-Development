using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        bool isMetric = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkEnglish_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEnglish.Visible = true;
            linkEnglish.Visible = false;
            txtMetric.Visible = false;
            linkMetric.Visible = true;
            isMetric = false;
            boxHeight2.Visible = true;
            txtHeightUnit2.Visible = true;
            txtHeightUnit1.Text = "Feet";
            txtWeightUnit.Text = "Pounds";
        }

        private void linkMetric_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEnglish.Visible = false;
            linkEnglish.Visible = true;
            txtMetric.Visible = true;
            linkMetric.Visible = false;
            isMetric = true;
            boxHeight2.Visible = false;
            txtHeightUnit2.Visible = false;
            txtHeightUnit1.Text = "Centimeters";
            txtWeightUnit.Text = "Kilograms";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double bmi = 0;
            string bmi_status = "";
            try
            {
                if (isMetric)
                {
                    bmi = double.Parse(boxWeight.Text) / (Math.Pow((double.Parse(boxHeight1.Text)/100.0), 2.0));
                }
                else
                {
                    bmi = (double.Parse(boxWeight.Text) / Math.Pow(((double.Parse(boxHeight1.Text)*12) + double.Parse(boxHeight2.Text)), 2.0)) * 703.0;
                }
                if (bmi < 18.5)
                {
                    bmi_status = "UnderWeight";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    bmi_status = "Healthy Weight";
                }
                else if(bmi >= 25.0 && bmi < 30.0)
                {
                    bmi_status = "OverWeight";
                }
                else
                {
                    bmi_status = "Obesity";
                }

                if( !(double.Parse(boxWeight.Text) < 0) && !(double.Parse(boxHeight1.Text) < 0))
                {
                   MessageBox.Show("Your BMI Index is: " + bmi.ToString("F") + "\nBy BMI standards you are categorized as: " + bmi_status);
                }
                else
                {
                    MessageBox.Show("The Weight and/or Height cannot be negative");
                }
                
            }
            catch
            {
                MessageBox.Show("uh oh, please insert numbers into the boxes");
            }
        }
    }
}
