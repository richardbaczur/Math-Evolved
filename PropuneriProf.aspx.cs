using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class PropuneriProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void pProb_Click(object sender, EventArgs e)
        {
            Response.Redirect("PropuneProb.aspx");
        }

        protected void pQuiz_Click(object sender, EventArgs e)
        {
            Response.Redirect("PropuneQuiz.aspx");
        }
    }
}