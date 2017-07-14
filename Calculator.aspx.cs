using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private static numb currentNumber = numb.NUMBER1;
        private static symbol currentSymbol;
        private bool zec = false;
        private static double n1;
        private static double n2;
        protected void b1_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 1, zec, rez);

        }

        protected void b2_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 2, zec, rez);
        }

        protected void b3_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 3, zec, rez);
        }

        protected void b4_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 4, zec, rez);
        }
//test
        protected void b5_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 5, zec, rez);
        }

        protected void b6_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 6, zec, rez);
        }

        protected void b7_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 7, zec, rez);
        }

        protected void b8_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 8, zec, rez);
        }

        protected void b9_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 9, zec, rez);
        }

        protected void b0_Click(object sender, EventArgs e)
        {
            Subprograme.addNumber(currentNumber, ref n1, ref n2, 0, zec, rez);
        }

        protected void zecimal_Click(object sender, EventArgs e)
        {
            this.zec = true;
        }

        protected void minusplus_Click(object sender, EventArgs e)
        {
            switch (currentNumber)
            {
                case numb.NUMBER1:
                    n1 *= -1;
                    rez.Text = n1.ToString();
                    break;
                case numb.NUMBER2:
                    n2 *= -1;
                    rez.Text = n2.ToString();
                    break;
            }
        }

        protected void su_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            if (n2 == 0)
            {
                rez.Text = "";
            }
            else
            {
                rez.Text = n2.ToString();
            }
            currentSymbol = symbol.SUM;
        }

        protected void di_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            if (n2 == 0)
            {
                rez.Text = "";
            }
            else
            {
                rez.Text = n2.ToString();
            }
            currentSymbol = symbol.DIF;
        }

        protected void eq_Click(object sender, EventArgs e)
        {
            Subprograme.rez(currentSymbol, ref n1, ref n2, rez);
        }

        protected void pr_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            if (n2 == 0)
            {
                rez.Text = "";
            }
            else
            {
                rez.Text = n2.ToString();
            }
            currentSymbol = symbol.PROD;
        }

        protected void im_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            if (n2 == 0)
            {
                rez.Text = "";
            }
            else
            {
                rez.Text = n2.ToString();
            }
            currentSymbol = symbol.IMP;
        }

        protected void sq_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            n1 = Math.Sqrt(n1);
            rez.Text = n1.ToString();
            currentSymbol = symbol.SUM;
        }

        protected void po_Click(object sender, EventArgs e)
        {
            currentNumber = numb.NUMBER2;
            if (n2 == 0)
            {
                rez.Text = "";
            }
            else
            {
                rez.Text = n2.ToString();
            }
            currentSymbol = symbol.PW;
        }
    }
}