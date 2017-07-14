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
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void prob_Click(object sender, EventArgs e)
        {
            Session["type"]='p';
            sel.Items.Clear();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProvisionalProbleme", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            sel.Items.Add(dt.Rows[i]["name"].ToString());
                        }
                    } 
                }
            }
        }

        protected void quiz_Click(object sender, EventArgs e)
        {
            Session["type"] = 'q';
            sel.Items.Clear();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProvisionalQuiz", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            sel.Items.Add(dt.Rows[i]["name"].ToString());
                        }
                    }
                }
            }
        }

        protected void prof_Click(object sender, EventArgs e)
        {
            Session["type"] = 't';
            sel.Items.Clear();
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProvisionalProfi", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            sel.Items.Add(dt.Rows[i]["username"].ToString());
                        }
                    }
                }
            }
        }

        protected void app_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            switch (Convert.ToChar(Session["type"]))
            {
                case 'p':
                    SqlCommand sele = new SqlCommand("SELECT * FROM ProvisionalProbleme WHERE name=@nm",con);
                    sele.Parameters.AddWithValue("@nm", sel.Text);

                    using (SqlDataAdapter sda = new SqlDataAdapter(sele))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        SqlCommand add = new SqlCommand("INSERT INTO Probleme VALUES(@name,@enunt,@rez)", con);
                        add.CommandType = CommandType.Text;
                        add.Parameters.AddWithValue("@name", dt.Rows[0]["name"]);
                        add.Parameters.AddWithValue("@enunt", dt.Rows[0]["enunt"]);
                        add.Parameters.AddWithValue("@rez", dt.Rows[0]["rezultat"]);
                        con.Open();
                        add.ExecuteNonQuery();
                        con.Close();
                    }
                    SqlCommand delp = new SqlCommand("DELETE FROM ProvisionalProbleme WHERE name=@nm",con);
                    delp.Parameters.AddWithValue("@nm", sel.Text);
                    con.Open();
                    delp.ExecuteNonQuery();
                    con.Close();
                    break;
                case 'q':
                    con.Open();
                    SqlCommand selec = new SqlCommand("SELECT * FROM ProvisionalQuiz WHERE name=@nm", con);
                    selec.Parameters.AddWithValue("@nm", sel.Text);
                    using (SqlDataAdapter sda = new SqlDataAdapter(selec))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        SqlCommand adaugareLaLista = new SqlCommand("INSERT INTO Quiz VALUES(@name,@desc)", con);
                        adaugareLaLista.Parameters.AddWithValue("@name", dt.Rows[0]["name"]);
                        adaugareLaLista.Parameters.AddWithValue("@desc", dt.Rows[0]["desc"]);
                        adaugareLaLista.CommandType = CommandType.Text;
                        adaugareLaLista.ExecuteNonQuery();
                        SqlCommand adaugareQuiz = new SqlCommand("INSERT INTO QuizData VALUES(@name,@e1,@e2,@e3,@e4,@e5,@v11,@v12,@v13,@v14,@v15,@v21,@v22,@v23,@v24,@v25,@v31,@v32,@v33,@v34,@v35,@v41,@v42,@v43,@v44,@v45,@v51,@v52,@v53,@v54,@v55,@vc1,@vc2,@vc3,@vc4,@vc5)", con);
                        adaugareQuiz.Parameters.AddWithValue("@name", dt.Rows[0]["name"]);
                        adaugareQuiz.Parameters.AddWithValue("@e1", dt.Rows[0]["e1"]);
                        adaugareQuiz.Parameters.AddWithValue("@e2", dt.Rows[0]["e2"]);
                        adaugareQuiz.Parameters.AddWithValue("@e3", dt.Rows[0]["e3"]);
                        adaugareQuiz.Parameters.AddWithValue("@e4", dt.Rows[0]["e4"]);
                        adaugareQuiz.Parameters.AddWithValue("@e5", dt.Rows[0]["e5"]);
                        adaugareQuiz.Parameters.AddWithValue("@v11", dt.Rows[0]["v11"]);
                        adaugareQuiz.Parameters.AddWithValue("@v12", dt.Rows[0]["v12"]);
                        adaugareQuiz.Parameters.AddWithValue("@v13", dt.Rows[0]["v13"]);
                        adaugareQuiz.Parameters.AddWithValue("@v14", dt.Rows[0]["v14"]);
                        adaugareQuiz.Parameters.AddWithValue("@v15", dt.Rows[0]["v15"]);
                        adaugareQuiz.Parameters.AddWithValue("@v21", dt.Rows[0]["v21"]);
                        adaugareQuiz.Parameters.AddWithValue("@v22", dt.Rows[0]["v22"]);
                        adaugareQuiz.Parameters.AddWithValue("@v23", dt.Rows[0]["v23"]);
                        adaugareQuiz.Parameters.AddWithValue("@v24", dt.Rows[0]["v24"]);
                        adaugareQuiz.Parameters.AddWithValue("@v25", dt.Rows[0]["v25"]); 
                        adaugareQuiz.Parameters.AddWithValue("@v31", dt.Rows[0]["v31"]);
                        adaugareQuiz.Parameters.AddWithValue("@v32", dt.Rows[0]["v32"]);
                        adaugareQuiz.Parameters.AddWithValue("@v33", dt.Rows[0]["v33"]);
                        adaugareQuiz.Parameters.AddWithValue("@v34", dt.Rows[0]["v34"]);
                        adaugareQuiz.Parameters.AddWithValue("@v35", dt.Rows[0]["v35"]);
                        adaugareQuiz.Parameters.AddWithValue("@v41", dt.Rows[0]["v41"]);
                        adaugareQuiz.Parameters.AddWithValue("@v42", dt.Rows[0]["v42"]);
                        adaugareQuiz.Parameters.AddWithValue("@v43", dt.Rows[0]["v43"]);
                        adaugareQuiz.Parameters.AddWithValue("@v44", dt.Rows[0]["v44"]);
                        adaugareQuiz.Parameters.AddWithValue("@v45", dt.Rows[0]["v45"]);
                        adaugareQuiz.Parameters.AddWithValue("@v51", dt.Rows[0]["v51"]);
                        adaugareQuiz.Parameters.AddWithValue("@v52", dt.Rows[0]["v52"]);
                        adaugareQuiz.Parameters.AddWithValue("@v53", dt.Rows[0]["v53"]);
                        adaugareQuiz.Parameters.AddWithValue("@v54", dt.Rows[0]["v54"]);
                        adaugareQuiz.Parameters.AddWithValue("@v55", dt.Rows[0]["v55"]);
                        adaugareQuiz.Parameters.AddWithValue("@vc1", dt.Rows[0]["vc1"]);
                        adaugareQuiz.Parameters.AddWithValue("@vc2", dt.Rows[0]["vc2"]);
                        adaugareQuiz.Parameters.AddWithValue("@vc3", dt.Rows[0]["vc3"]);
                        adaugareQuiz.Parameters.AddWithValue("@vc4", dt.Rows[0]["vc4"]);
                        adaugareQuiz.Parameters.AddWithValue("@vc5", dt.Rows[0]["vc5"]);
                        adaugareQuiz.CommandType = CommandType.Text;
                        adaugareQuiz.ExecuteNonQuery();
                    }
                    SqlCommand delq = new SqlCommand("DELETE FROM ProvisionalQuiz WHERE name=@nm",con);
                    delq.Parameters.AddWithValue("@nm", sel.Text);
                   
                    delq.ExecuteNonQuery();
                    con.Close();
                    break;
                case 't':
                    SqlCommand getP = new SqlCommand("SELECT * FROM ProvisionalProfi WHERE username=@name", con);
                    SqlCommand addP = new SqlCommand("INSERT INTO Profi VALUES(@name,@pass,@email,@inst,@img)", con);
                    SqlCommand delP = new SqlCommand("DELETE FROM ProvisionalProfi WHERE username=@name", con);
                    getP.Parameters.AddWithValue("@name", sel.Text);
                    delP.Parameters.AddWithValue("@name", sel.Text);
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(getP))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        addP.Parameters.AddWithValue("@name", dt.Rows[0]["username"]);
                        addP.Parameters.AddWithValue("@pass", dt.Rows[0]["password"]);
                        addP.Parameters.AddWithValue("@email", dt.Rows[0]["email"]);
                        addP.Parameters.AddWithValue("@inst", dt.Rows[0]["Institution"]);
                        addP.Parameters.AddWithValue("@img", "");
                        addP.ExecuteNonQuery();
                    }
                    delP.ExecuteNonQuery();
                    con.Close();
                    break;
                default:
                    break;
            }
        }
    }
}