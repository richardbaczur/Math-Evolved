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
    public partial class LogInProf : System.Web.UI.Page
    {
        public static string name;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Profi where username=@name", con);
                cmd.CommandType = System.Data.CommandType.Text; 
                cmd.Parameters.AddWithValue("@name", username.Text);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (Convert.ToString(dt.Rows[0]["password"]) == password.Text)
                    {
                        name = username.Text;
                        Response.Redirect("indexProf.aspx?user=" + username.Text);
                    }
                }
            }
            catch
            {

            }
        }
    }
}