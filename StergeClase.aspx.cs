using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace INfoEducatie
{
    public partial class StergeClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT Nume FROM Clase WHERE Profesor=@prof",con);
            cmd.Parameters.AddWithValue("@prof", INfoEducatie.LogInProf.name);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    del.Items.Add(dt.Rows[i]["Nume"].ToString());
                }
            }
        }

        protected void conf_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Clase WHERE Nume=@name", con);
            cmd.Parameters.AddWithValue("@name", del.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void canc_Click(object sender, EventArgs e)
        {

        }
    }
}