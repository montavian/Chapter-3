﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            double enteredName;
            enteredName = Convert.ToDouble(txtEnteredName.Text);
            lblOutput = "Goodbye, " + enteredName + "!";
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
             = "Goodbye, " + txtEnteredName.Text + "!";
        }

        private void goodbyeButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
