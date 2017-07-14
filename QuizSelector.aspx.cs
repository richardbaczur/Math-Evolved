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
    public partial class QuizSelector : System.Web.UI.Page
    {
        private string name;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            
        }

        protected void quizsel_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = quizsel.Text;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Description from Quiz where name=@name", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    descr.InnerHtml = Convert.ToString(dt.Rows[0]["Description"]);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        protected void btnRandom_Click(object sender, EventArgs e)
        {
            quizsel.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Quiz", con);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        name = Convert.ToString(dt.Rows[i]["name"]);
                        quizsel.Items.Add(name);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                con.Close();
            }
        }

        protected void start_Click(object sender, EventArgs e)
        {
            Response.Redirect("Quiz.aspx?quiz="+quizsel.Text);
        }
    }
}