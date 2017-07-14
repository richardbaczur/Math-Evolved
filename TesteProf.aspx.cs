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
    public partial class TesteProf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sel.Items.Clear();
            quiz.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cls = new SqlCommand("SELECT Nume FROM Clase", con);
            SqlCommand teste = new SqlCommand("SELECT name FROM Quiz", con);
            using (SqlDataAdapter sda = new SqlDataAdapter(cls))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sel.Items.Add(dt.Rows[i]["Nume"].ToString());
                }
            }
            using (SqlDataAdapter sda = new SqlDataAdapter(teste))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    quiz.Items.Add(dt.Rows[i]["name"].ToString());
                }
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            if (nume.Text != "" && sel.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO Teste VALUES(@name,@cls,@quiz,@note,@elevi)", con);
                cmd.Parameters.AddWithValue("@name", nume.Text);
                cmd.Parameters.AddWithValue("@cls", sel.Text);
                cmd.Parameters.AddWithValue("@quiz", quiz.Text);
                cmd.Parameters.AddWithValue("@note", "");
                cmd.Parameters.AddWithValue("@elevi", "");
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}