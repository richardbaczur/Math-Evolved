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
    public partial class Probleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void refresh_Click(object sender, EventArgs e)
        {
            probsel.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Probleme", con);
                cmd.CommandType = CommandType.Text;
                using(SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        probsel.Items.Add(dt.Rows[i]["name"].ToString());
                    }
                }
            }
            catch
            {

            }
        }

        protected void start_Click(object sender, EventArgs e)
        {
            Response.Redirect("Problema.aspx?name="+probsel.SelectedItem.Text);
        }
    }
}