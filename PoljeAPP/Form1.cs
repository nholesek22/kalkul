﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoljeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int i = 0;
        private int[] polje = new int[100];
        private void btnIza_Click(object sender, EventArgs e)
        {
            if (!(i == 0)) i -= 1;
            txtElBr.Text = Convert.ToString(i);
            txtElement.Text = Convert.ToString(polje[i]);
        }
        private void btnSljedeci_Click(object sender, EventArgs e)
        {
            if (!(i == 100)) i += 1;
            txtElBr.Text = Convert.ToString(i);
            txtElement.Text = Convert.ToString(polje[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            polje[i] = Convert.ToInt32(txtElement.Text);
        }

        
    }
}
