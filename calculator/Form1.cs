using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double x, y;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers(object sender, EventArgs e)
        {
            if (txtBox.Text == "0")
                txtBox.Text = "";
            int j = 0;
            if (((Button)sender).Text == ".")
            {
                foreach (char i in txtBox.Text)
                    if (i == '.')
                    {
                        j = 1;
                        break;
                    }
                if (j == 0)
                    txtBox.Text += ((Button)sender).Text;
            }
            else
                txtBox.Text += ((Button)sender).Text;


        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblPreNum2.Text = lblPreNum1.Text;
            lblPreNum1.Text = txtBox.Text;
            y = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "";
            double z = 0;
            switch (op)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "*":
                    z = x * y;
                    break;
                case "/":
                    z = x / y;
                    break;
            }
            op = "";
            txtBox.Text = Convert.ToString(z);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            op = "";
            txtBox.Text = "0";
            btnEqual.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEqual.Enabled = false;
        }

        private void btnOnoff_Click(object sender, EventArgs e)
        {
            if (pnl.Enabled == true)
            {
                pnl.Enabled = false;
                x = 0;
                y = 0;
                op = "";
            }
            else
                pnl.Enabled = true;
        }

        private void operators(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                x = Convert.ToDouble(txtBox.Text);
                lblPreNum1.Text = txtBox.Text;
            }
            txtBox.Text = "";
            op = ((Control)sender).Text;
            btnEqual.Enabled = true;
        }
    }
}
