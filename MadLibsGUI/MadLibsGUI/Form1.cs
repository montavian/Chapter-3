using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtPick1.Text) - Convert.ToDouble(txtPick2.Text);

            lblResults.Text = "The " + txtColor.Text + " Dragon is the " + txtWordEst.Text +
                " Dragon of all. It has " + num + " " + txtBodyPlural.Text + ", and a " + txtAnimal.Text +
                 " shaped like a " + txtNoun.Text + ", although it feast on nearly anything.";
        }
    }
}
