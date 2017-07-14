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
    public partial class Problema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            try
            {
                SqlCommand cmd = new SqlCommand("select enunt from Probleme where name=@name", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", Request.QueryString["name"]);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    text.InnerText = dt.Rows[0]["enunt"].ToString();
                }
            }
            catch
            {

            }
            title.Text = Request.QueryString["name"];
            probtitle.InnerText = Request.QueryString["name"];
        }

        protected void trimite_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("select rezultat from Probleme where name=@name", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", Request.QueryString["name"]);
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (rez.Text == dt.Rows[0]["rezultat"].ToString())
                    {
                        corectare.Text = "Corect!";
                        SqlCommand upProf = new SqlCommand("UPDATE Users SET probleme = @nprobleme WHERE username=@name", con);
                        upProf.Parameters.AddWithValue("@nprobleme", getNumProb(con));
                        upProf.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
                        upProf.ExecuteNonQuery();
                        inapoi.Visible = true;
                    }
                    else
                    {
                        corectare.Text = "Gresit!";
                    }
                }


        }
        private string getNumProb(SqlConnection con)
        {
            string ret="";
            SqlCommand cmd = new SqlCommand("SELECT probleme FROM Users WHERE username=@name",con);
            cmd.Parameters.AddWithValue("@name",INfoEducatie.Log_In.name);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string[] aux = dt.Rows[0]["probleme"].ToString().Split(',');
                for (int i = 0; i < aux.Length; i++)
                {
                    if (aux[i] == Request.QueryString["name"])
                    {
                        return dt.Rows[0]["probleme"].ToString();
                    }
                }
                    if (dt.Rows[0]["probleme"].ToString() != "0")
                    {
                        ret += dt.Rows[0]["probleme"].ToString();
                        ret += "," + Request.QueryString["name"];
                    }
                    else ret = Request.QueryString["name"];
            }
            return ret;
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProblemeSel.aspx");
        }
    }
}