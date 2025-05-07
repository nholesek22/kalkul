using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private decimal brojnik = 0.0m;
        private decimal nazivnik = 0.0m;
        private void DigitBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (DisplayTextBox.Text == "0") DisplayTextBox.Clear();
            DisplayTextBox.Text += btn.Text;
        }

        private void dotbutton_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains('.')) DisplayTextBox.Text += ".";
        }

        private void plusminus_Click(object sender, EventArgs e)
        {
            if (!DisplayTextBox.Text.Contains("-")) DisplayTextBox.Text = "-" + DisplayTextBox.Text;
            else DisplayTextBox.Text = DisplayTextBox.Text.Trim('-');
        } 
    }
}