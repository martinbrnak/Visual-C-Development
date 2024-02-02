using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProblem4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            txtJoke.Text = "Why do Java programmers have to wear glasses?";
        }

        private void btnPunchLine_Click(object sender, EventArgs e)
        {
            txtJoke.Text = "Because they don't C#";
        }
    }
}
