using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class ClaseProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void create_Click(object sender, EventArgs e)
        {
            sectie.Src = "CreeazaClasa.aspx";
        }

        protected void manage_Click(object sender, EventArgs e)
        {
            sectie.Src = "ManageClase.aspx";
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            sectie.Src = "StergeClase.aspx";
        }

        protected void tema_Click(object sender, EventArgs e)
        {
            sectie.Src = "TemeClase.aspx";
        }
    } 
}