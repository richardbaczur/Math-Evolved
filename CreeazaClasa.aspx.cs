using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace INfoEducatie
{
    public partial class CreeazaClasa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void done_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("INSERT INTO Clase VALUES(@nume,@niv,@prof,@elevi,@teme)", con);
            cmd.Parameters.AddWithValue("@nume", nume.Text);
            cmd.Parameters.AddWithValue("@niv", clasa.Text);
            cmd.Parameters.AddWithValue("@prof", INfoEducatie.LogInProf.name);
            cmd.Parameters.AddWithValue("@elevi", "");
            cmd.Parameters.AddWithValue("@teme", "");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            success.Visible = true;
        }
    }
}