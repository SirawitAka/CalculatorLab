using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float sum,num;
        int begin = 0;
        int start = 0;
        int ans = 0;
        int digit = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if(lblDisplay.Text == "0"){
                    lblDisplay.Text = "1";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "1";
                    begin = 0;
                }
                else {
                    lblDisplay.Text = lblDisplay.Text + 1;
                }
                digit++;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "2";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "2";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 2;
                }
                digit++;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "3";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "3";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 3;
                }
                digit++;
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "4";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "4";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 4;
                }
                digit++;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "5";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "5";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 5;
                }
                digit++;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "6";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "6";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 6;
                }
                digit++;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "7";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "7";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 7;
                }
                digit++;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "8";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "8";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 8;
                }
                digit++;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "9";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "9";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 9;
                }
                digit++;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblDisplay.Text);
                if (start == 0)
                    {
                        ans = 1;
                    }
                    begin = 1;
            btnEqual_Click(sender, e);
            ans = 1;
            start = 1;
            lblDisplay.Text = sum.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblDisplay.Text);
            if (start == 0)
            {
                ans = 2;
            }
            begin = 1;
            btnEqual_Click(sender, e);
            ans = 2;
            start = 1;
            lblDisplay.Text = sum.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblDisplay.Text);
            if (start == 0)
            {
                ans = 4;
            }
            begin = 1;
            btnEqual_Click(sender, e);
            ans = 4;
            start = 1;
            lblDisplay.Text = sum.ToString();
        }

            private void btnEqual_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblDisplay.Text);
            switch (ans)
            {
                case 1:
                    sum = sum + num;
                    break;
                case 2:
                    if (start == 0)
                    {
                        start = 1;
                        sum = num;
                    }
                    else
                    {
                        sum = sum - num;
                    }
                    break;
                case 3:
                    if (start == 0)
                    {
                        start = 1;
                        sum = 1;
                        sum = sum * num;
                    }
                    else
                    {
                        sum = sum * num;
                    }
                    break;
                case 4:
                    if (start == 0)
                    {
                        start = 1;
                        sum = num;
                    }
                    else
                    {
                        sum = sum / num;
                    }
                    break;
            }
            lblDisplay.Text = sum.ToString();
            if(lblDisplay.Text.Length > 9)
            {
               lblDisplay.Text = "Error";
            }
            begin = 1;
            digit = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            num = 0;
            sum = 0;
            start = 0;
            begin = 0;
            digit = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (digit < 8)
            {
                if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = "0";
                }
                else if (begin == 1)
                {
                    lblDisplay.Text = "0";
                    begin = 0;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + 0;
                }
                digit++;
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double sumpercent;
            sumpercent = double.Parse(lblDisplay.Text);
            sumpercent = sum*(sumpercent / 100.00);
            lblDisplay.Text = sumpercent.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text.Remove(lblDisplay.Text.Length - 1,1);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num = float.Parse(lblDisplay.Text);
            if (start == 0)
            {
                ans = 3;
            }
            begin = 1;
            btnEqual_Click(sender, e);
            ans = 3;
            start = 1;
            lblDisplay.Text = sum.ToString();
        }
    }
}
