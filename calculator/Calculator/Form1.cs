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
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;

            int sum;

            num1 = Convert.ToInt32(this.FirstNumber.Text);
            num2 = Convert.ToInt32(this.SecondNumber.Text);

            sum = num1 + num2;

            lbl_Numresults.Text = " Sum is " + sum;
        }
    }
}
