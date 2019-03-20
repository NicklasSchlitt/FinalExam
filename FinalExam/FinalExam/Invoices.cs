﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExam
{
    public partial class Invoices : Form
    {
        int totalcost = 22608;
        double fluidcheckup = 24.99;
        public Invoices()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoesCRM joes = new JoesCRM();
            joes.Show(this);
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            label1.Text = "$" + totalcost.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "$" + (totalcost + fluidcheckup).ToString();
            }
            else
            {
                label1.Text = "$" + totalcost.ToString();
            }
        }
    }
}
