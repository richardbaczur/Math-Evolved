using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class indexProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            user.InnerText = "Welcome, " + INfoEducatie.LogInProf.name + "!";
        } 
    }
}