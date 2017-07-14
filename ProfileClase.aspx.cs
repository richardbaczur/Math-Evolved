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
    public partial class ProfileClase : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username=@name", con);
            cmd.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0]["image"].ToString() != "")
                {
                    profilePic.Src = "~/upload/" + INfoEducatie.Log_In.name + ".jpg";
                }
                else profilePic.Src = "profile.jpg";
                mail.InnerText = dt.Rows[0]["email"].ToString();
                string[] auxp = dt.Rows[0]["probleme"].ToString().Split(',');
                probleme.InnerText = "Ai rezolvat " + auxp.Length.ToString() + " probleme corect!";
                accType.InnerText = "Elev";
                string[] auxq = dt.Rows[0]["quiz"].ToString().Split(',');
                quiz.InnerText = "Ai rezolvat " + auxq.Length.ToString() + " quiz-uri corect!";
            }
            cmd = new SqlCommand("SELECT * FROM Clase",con);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] aux = dt.Rows[i]["Elevi"].ToString().Split(',');
                    for (int j = 0; j < aux.Length; j++)
                    {
                        if (aux[j] == INfoEducatie.Log_In.name) clasa.Items.Add(dt.Rows[i]["Nume"].ToString());
                    }
                }
            }
            con.Close();
        }

        protected void picSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Users SET image=@img WHERE username=@name", con);
            cmd.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            cmd.Parameters.AddWithValue("@img", INfoEducatie.Log_In.name);
            picFile.SaveAs(Server.MapPath("~/upload/" + INfoEducatie.Log_In.name + ".jpg"));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Profile.aspx");
        }

        protected void sel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Teme FROM Clase WHERE Nume=@name",con);
            SqlCommand pr = new SqlCommand("SELECT probleme FROM Users WHERE username=@name",con);
            pr.Parameters.AddWithValue("@name", INfoEducatie.Log_In.name);
            cmd.Parameters.AddWithValue("@name", clasa.Text);
            
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                using (SqlDataAdapter sda2 = new SqlDataAdapter(pr))
                {
                    DataTable dt2 = new DataTable();
                    sda2.Fill(dt2);
                    if (dt.Rows[0]["Teme"].ToString() == "")
                    {
                        teme.InnerText = "Nu aveti teme!";
                    }
                    else
                    {
                        string[] tema = dt.Rows[0]["Teme"].ToString().Split(',');
                        string[] rez = dt2.Rows[0]["probleme"].ToString().Split(',');
                        string[] rest = new string[100];
                        int restindex = 0;
                        for (int i = 0; i < tema.Length; i++)
                        {
                            bool found = false;
                            for (int j = 0; j < rez.Length; j++)
                            {
                                if (tema[i] == rez[j]) found = true;
                            }
                            if (!found)
                            {
                                rest[restindex++] = tema[i];
                            }
                        }
                        if (restindex == 0)
                        {
                            teme.InnerText = "Nu aveti teme!";
                        }
                        else
                        {
                            teme.InnerHtml = "Aveti teme! Pentru a rezolva, apasati pe una dintre problemele din lista de mai jos!<br />";
                            for (int i = 0; i < rest.Length; i++)
                            {
                                lista.InnerHtml += "<a href=\"Problema.aspx?name=" + rest[i] + "\">" + rest[i] + "</a>";
                            }
                        }
                    }
                    
                }
            }
            cmd = new SqlCommand("SELECT * FROM Teste WHERE Clasa=@cls",con);
            cmd.Parameters.AddWithValue("@cls", clasa.Text);
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    
                    if (dt.Rows[0]["Quiz"].ToString() == "")
                    {
                        test.InnerText = "Nu aveti niciun test!";
                    }
                    else
                    {
                        test.InnerHtml = "Aveti un test! Click aici pentru a-l rezolva!<a href=\"Quiz.aspx?type=\"test\"&tname="+dt.Rows[0]["Nume"].ToString()+"\">Rezolva!</a>";
                    }
                }
            }
            catch (Exception err) { test.InnerText = "Nu aveti niciun test!"; }
        }
    }
}