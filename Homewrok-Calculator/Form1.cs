using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homewrok_Calculator
{
    public partial class Calculator : Form
    {
        string calculation = "";
        double number = 0;
        bool op = true;
        bool IsDecimal = true;
        double memory;


        public Calculator()
        {
            InitializeComponent();
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            btnMPlus.Enabled = false;
            btnMMinus.Enabled = false;

        }
        private void buttonNum_Click(object sender, EventArgs e)
        {
            //lblResult.Text = lblResult.Text + "7";

            //--------------------------//
            if (tbResult.Text == "0" || (op))
                // lblResult.Text = "";
                tbResult.ResetText();
            op = false;
            //-------------------------//
            Button button = (Button)sender;
            //------------------------------
            if (button.Text == ".")
            {
                //if(!lblResult.Text.Contains("."))
                if (IsDecimal)
                {
                    tbResult.Text = tbResult.Text + button.Text;
                    IsDecimal = false;
                }
            }
            else
                tbResult.Text = tbResult.Text + button.Text;
            //------------------------------
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            tbResult.ResetText();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
        }
        private void Calculation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculation = button.Text;
            number = double.Parse(tbResult.Text);
            op = true;
            IsDecimal = true;

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (calculation)
            {
                case "+":
                    tbResult.Text = (number + double.Parse(tbResult.Text)).ToString();
                    break;
                case "-":
                    tbResult.Text = (number - double.Parse(tbResult.Text)).ToString();
                    break;
                case "X":
                    tbResult.Text = (number * double.Parse(tbResult.Text)).ToString();
                    break;
                case "/":
                    tbResult.Text = (number / double.Parse(tbResult.Text)).ToString();
                    break;
                case "√":
                    tbResult.Text = Math.Sqrt(number).ToString();
                    break;
                default:
                    break;
            }
            op = true;
            IsDecimal = true;
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;
                case "1":
                    button1.PerformClick();
                    break;
                case "2":
                    button02.PerformClick();
                    break;
                case "3":
                    button03.PerformClick();
                    break;
                case "4":
                    button04.PerformClick();
                    break;
                case "5":
                    button05.PerformClick();
                    break;
                case "6":
                    button06.PerformClick();
                    break;
                case "7":
                    button07.PerformClick();
                    break;
                case "8":
                    button08.PerformClick();
                    break;
                case "9":
                    button09.PerformClick();
                    break;
                case ".":
                    buttonPoint.PerformClick();
                    break;
                case "+":
                    buttonAdd.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonMultiply.PerformClick();
                    break;
                case "/":
                    buttonDiv.PerformClick();
                    break;
                case " ":
                    btnResult.PerformClick();
                    break;
                case "\r":
                    btnResult.PerformClick();
                    break;
                default:
                    break;
            }
            if (e.KeyChar == (char)Keys.Escape)
                tbResult.Text = "0";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memory = 0;
            btnMC.Enabled = false;
            btnMR.Enabled = false;
            btnMPlus.Enabled = false;
            btnMMinus.Enabled = false;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = double.Parse(tbResult.Text);
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            btnMPlus.Enabled = true;
            btnMMinus.Enabled = true;
        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(tbResult.Text);
        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memory -= double.Parse(tbResult.Text);
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            tbResult.Text = memory.ToString();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            MessageBox.Show(memory.ToString());

        }
    }
}
