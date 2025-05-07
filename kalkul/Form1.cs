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
        private decimal rezultat = 0.0m;
        private int operatorType = (int)operacije.NoOp;
        // 1 zbrajanje 2 mnozenje 3 oduzimanje 4 dijeljenje
        public enum operacije
        {
            NoOp = 0,
            plus = 1,
            Minus = 3,
            dijeli = 4,
            puta = 2
        }
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
        private void spremi(int operacija) 
        {
            operatorType = operacija;
            brojnik = Convert.ToDecimal(DisplayTextBox.Text);
            DisplayTextBox.Text = "0";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            spremi((int)operacije.plus);
        }

        private void puta_Click(object sender, EventArgs e)
        {
            spremi((int)operacije.puta);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            spremi((int)operacije.Minus);
        }

        private void dijeli_Click(object sender, EventArgs e)
        {
            spremi((int)operacije.dijeli);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nazivnik = Convert.ToDecimal(DisplayTextBox.Text);
            switch (operatorType)
            {
                case 1:
                    rezultat = brojnik + nazivnik;
                    break;
                case 2:
                    rezultat = brojnik * nazivnik;
                    break;
                case 3:
                    rezultat = brojnik - nazivnik;
                    break;
                case 4:
                    rezultat = brojnik / nazivnik;
                    break;
                default:
                    DisplayTextBox.Text = "Krivi unos";
                    break;
            }
            DisplayTextBox.Text = Convert.ToString(rezultat);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            operatorType = 0;
            brojnik = 0.0m;
            nazivnik = 0.0m;
            rezultat = 0.0m;
        }
    }
}