﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResuls_Click(object sender, EventArgs e)
        {
            
            double newSalary;

            newSalary = Convert.ToDouble(txtEntry.Text) * 1.04;

            lblResults.Text = " Your new Salary is " + newSalary;




        }
    }
}
