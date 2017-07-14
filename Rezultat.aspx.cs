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
    public partial class Rezultat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            quiztitle.InnerText = Request.QueryString["name"];
            rez.InnerHtml = "Ai obtinut "+Request.QueryString["rez"]+" puncte din 10!";
            if (Request.QueryString["rez"] == "10")
            {
                addToDB();
            }
            if (Request.QueryString["type"] == "test")
            {
                Test();
            }
        }

        private void Test()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand sel = new SqlCommand("SELECT * FROM Teste WHERE Nume=@name", con);
            SqlCommand cmd = new SqlCommand("UPDATE Teste SET Note=@nota, Elevi=@elev WHERE Nume=@name", con);
            sel.Parameters.AddWithValue("@name", Request.QueryString["tname"]);
            cmd.Parameters.AddWithValue("@name", Request.QueryString["tname"]);
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(sel))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string elevi = dt.Rows[0]["Elevi"].ToString() + "," + INfoEducatie.Log_In.name;
                string note = dt.Rows[0]["Note"].ToString() + "," + Request.QueryString["rez"];

                cmd.Parameters.AddWithValue("@nota", note);
                cmd.Parameters.AddWithValue("@elev", elevi);
            }
            con.Close();

        }

        private void addToDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand update = new SqlCommand("UPDATE Users SET quiz=@nquiz WHERE username=@name", con);
            SqlCommand extragere = new SqlCommand("SELECT quiz FROM Users WHERE username=@name", con);
            extragere.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            update.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(extragere))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string[] aux = dt.Rows[0]["quiz"].ToString().Split(',');
                for (int i = 0; i < aux.Length; i++)
                {
                    if (Request.QueryString["name"] != aux[i])
                    {
                        continue;
                    }
                    else return;
                }
                if (dt.Rows[0]["quiz"].ToString() == "" || dt.Rows[0]["quiz"].ToString() == null)
                {
                    update.Parameters.AddWithValue("@nquiz", Request.QueryString["name"]);
                }
                else
                {
                    update.Parameters.AddWithValue("@nquiz", dt.Rows[0]["quiz"] + "," + Request.QueryString["name"]);
                }
                update.ExecuteNonQuery();
            }
            con.Close();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}