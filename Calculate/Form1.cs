using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Calculate;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Calculate
{
    public partial class fCalc : Form
    {


        public fCalc()
        {
            InitializeComponent();
        }


        Operations operations = new Operations();
        public bool tm = false;
        bool NewOp = true;
        int op = -1;
        public double a = 0, b = 0, c = 0;
        




        private void fCalc_LocationChanged(object sender, EventArgs e)
        {

        }

        private void fCalc_Load(object sender, EventArgs e)
        {

        }

        private void tb_Calc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back) || e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                if (NewOp)
                {
                    tb_Calc.Text = "";
                    NewOp = false;
                }
                if (e.KeyChar == '.') e.KeyChar = ',';
                if (e.KeyChar == ',' && tb_Calc.Text.IndexOf(',') > -1) e.Handled = true;
                if (e.KeyChar == '0' && tb_Calc.Text == "0") e.Handled = true;
                if (tb_Calc.Text == "0" && e.KeyChar >= '1' && e.KeyChar <= '9') tb_Calc.Text = "";
            }
            else e.Handled = true;
        }

        private void bNum1_Click(object sender, EventArgs e)
        {
            if (NewOp == true || tb_Calc.Text == "0")
            {
                tb_Calc.Text = (sender as Button).Text;
                NewOp = false;
            }
            else tb_Calc.Text += (sender as Button).Text;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            op = -1;
            tb_Calc.Text = "0";
            NewOp = true;
        }

        private void bPoint_Click(object sender, EventArgs e)
        {
            if (NewOp)
            {
                tb_Calc.Text = "0";
                NewOp = false;
            }
            if (tb_Calc.Text.IndexOf(",") == -1) tb_Calc.Text += ',';

        }

        public double _bRavno_Click(double a, double b, int op)
        {
            switch (op)
            {
                case 1:
                    c = operations.plus(a, b);
                    break;
                case 2:
                    c = operations.minus(a, b);
                    break;
                case 3:
                    c = operations.multiply(a, b);
                    break;
                case 4:
                    c = operations.divide(a, b);
                    break;
                case 5:
                    c = operations.pow(a, b);
                    break;
            }
            
            return c;
        }

        public void bRavno_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(tb_Calc.Text);
            switch (op)
            {
                case 1:
                    c = operations.plus(a, b);
                    break;
                case 2:
                    c = operations.minus(a, b);
                    break;
                case 3:
                    c = operations.multiply(a, b);
                    break;
                case 4:
                    c = operations.divide(a, b);
                    break;
                case 5:
                    c = operations.pow(a, b);
                    break;
            }
            tb_Calc.Text = Convert.ToString(c);
            NewOp = true;
            op = -1;
           

        }

        private void bPlus_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 1;

            }
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            if (!(tb_Calc.Text.IndexOf("-") > -1 && tb_Calc.Text.Length - 1 == tb_Calc.Text.IndexOf("-")))
            {
                if (tb_Calc.Text == "" || tb_Calc.Text == "0")
                {
                    tb_Calc.Text = "-";
                    NewOp = false;
                    op = -1;
                }
                else
                {


                    if (op > 0)
                        bRavno_Click(sender, e);
                    a = Convert.ToDouble(tb_Calc.Text);
                    NewOp = true;
                    op = 2;
                }

            }

        }

        private void bUmn_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {

                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 3;
            }
        }

        private void bDelenie_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {

                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 4;
            }
        }

        private void bsin_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = operations.sin(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bCos_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = operations.cos(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }

        private void bTg_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            tb_Calc.Text = operations.tan(Convert.ToDouble(tb_Calc.Text)).ToString();
            NewOp = true;
            op = -1;
        }














        private void bx_y_Click(object sender, EventArgs e)
        {
            if (tb_Calc.Text == "") tb_Calc.Text = "0";
            else
            {
                if (op > 0)
                    bRavno_Click(sender, e);
                a = Convert.ToDouble(tb_Calc.Text);
                NewOp = true;
                op = 5;
            }
        }



        private void tb_Calc_TextChanged(object sender, EventArgs e)
        {

        }

        

       
    }       
    
}
