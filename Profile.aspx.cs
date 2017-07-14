using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace INfoEducatie
{
    public partial class Profile : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username=@name", con);
            cmd.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0]["image"].ToString() != "")
                {
                    profilePic.Src = "~/upload/" + INfoEducatie.Log_In.name+".jpg";
                }
                else profilePic.Src = "profile.jpg";
                mail.InnerText = dt.Rows[0]["email"].ToString();
                string[] auxp = dt.Rows[0]["probleme"].ToString().Split(',');
                probleme.InnerText = "Ai rezolvat " + auxp.Length.ToString() + " probleme corect!";
                accType.InnerText = "Elev";
                string[] auxq = dt.Rows[0]["quiz"].ToString().Split(',');
                quiz.InnerText = "Ai rezolvat " + auxq.Length.ToString() + " quiz-uri corect!";
                for (int i = 0; i < auxp.Length; i++)
                {
                    pro.InnerHtml += auxp[i] + "<br /><br /><hr /><br />";
                }
                for (int i = 0; i < auxq.Length; i++)
                {
                    qui.InnerHtml += auxq[i] + "<br /><br /><hr /><br />";
                }
            }
            con.Close();
        }

        protected void picSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("UPDATE Users SET image=@img WHERE username=@name",con);
            cmd.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            cmd.Parameters.AddWithValue("@img", INfoEducatie.Log_In.name);
            picFile.SaveAs(Server.MapPath("~/upload/"+INfoEducatie.Log_In.name+".jpg"));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Profile.aspx");
        }

        protected void cls_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileClase.aspx");
        }
    }
}