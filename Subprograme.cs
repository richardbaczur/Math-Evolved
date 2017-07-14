using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace INfoEducatie
{
    public enum numb
    {
        NUMBER1,
        NUMBER2,
    }
    public enum symbol
    {
        SUM,
        DIF,
        PROD,
        IMP,
        PW
    }
    public static class Subprograme
    {
        public static void addNumber(numb number, ref double n1, ref double n2, double add, bool zec,TextBox text)
        {
            if (!zec)
            {
                switch (number)
                {
                    case numb.NUMBER1:
                        n1 = n1 * 10 + add;
                        text.Text = n1.ToString();
                        break;
                    case numb.NUMBER2:
                        n2 = n2 * 10 + add;
                        text.Text = n2.ToString();
                        break;
                }
            }
            else
            {
                switch (number)
                {
                    case numb.NUMBER1:
                        n1 = n1 + add;
                        text.Text = n1.ToString();
                        break;
                    case numb.NUMBER2:
                        n2 = n2 + add;
                        text.Text = n2.ToString();
                        break;
                }
            }
        }
        public static void rez(symbol symb, ref double n1, ref double n2,TextBox text)
        {
            switch (symb)
            {
                case symbol.SUM:
                    n1 += n2;
                    n2 = 0;
                    text.Text = n1.ToString();
                    break;
                case symbol.DIF:
                    n1 -= n2;
                    n2 = 0;
                    text.Text = n1.ToString();
                    break;
                case symbol.IMP:
                    n1 /= n2;
                    n2 = 0;
                    text.Text = n1.ToString();
                    break;
                case symbol.PROD:
                    n1 *= n2;
                    n2 = 0;
                    text.Text = n1.ToString();
                    break;
                case symbol.PW:
                    n1 = Math.Pow(n1, n2);
                    n2 = 0;
                    text.Text = n1.ToString();
                    break;
                default:
                    break;
            }
        }
        public static string getAnswer(string literaVariantaCorecta, string varianta1, string varianta2, string varianta3, string varianta4, string varianta5)
        {
            string ret = "";
            if (literaVariantaCorecta.Equals("A"))
            {
                ret = varianta1;
            }
            else if (literaVariantaCorecta.Equals("B"))
            {
                ret = varianta2;
            }
            else if (literaVariantaCorecta.Equals("C"))
            {
                ret = varianta3;
            }
            else if (literaVariantaCorecta.Equals("D"))
            {
                ret = varianta4;
            }
            else if (literaVariantaCorecta.Equals("E"))
            {
                ret = varianta5;
            }
            return ret;
        }
    }
}