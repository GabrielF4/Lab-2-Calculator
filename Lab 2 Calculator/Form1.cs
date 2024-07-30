using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_2_Calculator
{
    public partial class Form1 : Form
    {
        double? Number1;
        double? Number2;
        string Operation;
        bool replaceDisplayText = true;

        private void clear_Text()
        {
            lblResult.Text = "0";
            replaceDisplayText = true;
        }

        private double? calculateNum(double? num1, double? num2, string op)
        {
            if (op.Equals("+"))
            {
                return num1 + num2;
            }
            else if (op.Equals("-"))
            {
                return num1 - num2;
            }
            else if (op.Equals("*"))
            {
                return Math.Round((num1 * num2).Value, 6);
            }
            else if (op.Equals("/"))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Du kan inte dela med 0!");
                    Number1 = null;
                    return 0;
                }

                return Math.Round((num1 / num2).Value, 6);

            }
            else
            {
                return null;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            if(lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "1";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "2";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "3";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "4";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "5";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "6";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "7";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "8";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "9";
                replaceDisplayText = false;
            }
            else
            {
                lblResult.Text += "9";
            }

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 11) { return; }

            if (!replaceDisplayText)
            {
                lblResult.Text += "0";
            }
        }

        private void btn_comma_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length >= 10) { return; }

            if (replaceDisplayText)
            {
                lblResult.Text = "0.";

            }
            else if (!lblResult.Text.Contains("."))
            {
                lblResult.Text += ".";
            }

            replaceDisplayText = false;
        }

        private void btn_sign_Click(object sender, EventArgs e)
        {

            if (lblResult.Text.Equals("0") || lblResult.Text.Equals("")) { return; }

            if (lblResult.Text.StartsWith("-"))
            {
                lblResult.Text = lblResult.Text.Replace("-", "");

            }
            else
            {
                lblResult.Text = "-" + lblResult.Text;
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (Number1.HasValue && !Operation.Equals(""))
            {
                Number2 = Convert.ToDouble(lblResult.Text);
                Number1 = calculateNum(Number1, Number2, Operation);
                lblResult.Text = "" + Number1;

                Operation = "+";
                replaceDisplayText = true;
                Number1 = null;
            }
            else
            {
                Number1 = Convert.ToDouble(lblResult.Text);
                Operation = "+";
                clear_Text();
            }

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (Number1.HasValue && !Operation.Equals(""))
            {
                Number2 = Convert.ToDouble(lblResult.Text);
                Number1 = calculateNum(Number1, Number2, Operation);
                lblResult.Text = "" + Number1;

                Operation = "-";
                replaceDisplayText = true;
            }
            else
            {
                Number1 = Convert.ToDouble(lblResult.Text);
                Operation = "-";
                clear_Text();
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (Number1.HasValue && !Operation.Equals(""))
            {
                Number2 = Convert.ToDouble(lblResult.Text);
                Number1 = calculateNum(Number1, Number2, Operation);
                lblResult.Text = "" + Number1;

                Operation = "*";
                replaceDisplayText = true;
            }
            else
            {
                Number1 = Convert.ToDouble(lblResult.Text);
                Operation = "*";
                clear_Text();
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (Number1.HasValue && !Operation.Equals(""))
            {
                Number2 = Convert.ToDouble(lblResult.Text);
                Number1 = calculateNum(Number1, Number2, Operation);
                lblResult.Text = "" + Number1;

                Operation = "/";
                replaceDisplayText = true;
            }
            else
            {
                Number1 = Convert.ToDouble(lblResult.Text);
                Operation = "/";
                clear_Text();
            }
        }

        private void btn_eql_Click(object sender, EventArgs e)
        {

            if (Number1.HasValue && !Operation.Equals(""))
            {
                Number2 = Convert.ToDouble(lblResult.Text);
                Number1 = calculateNum(Number1, Number2, Operation);
                lblResult.Text = $"{Number1}";
                replaceDisplayText = true;
            }

            Operation = "";
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            lblResult.Text = lblResult.Text.Remove(lblResult.Text.Length - 1, 1);

            if (lblResult.Text.Equals("") || lblResult.Text.Equals("-"))
            {
                lblResult.Text = "0";
                replaceDisplayText = true;
            }
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            Number1 = null;
            Number2 = null;
            Operation = "";
            replaceDisplayText = true;
            clear_Text();
        }
    }
}
