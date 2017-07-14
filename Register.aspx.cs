using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace INfoEducatie
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("INSERT INTO Users VALUES (@name,@pass,@email,@prob,@img,@quiz)");
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@prob", "0");
            cmd.Parameters.AddWithValue("@img", "");
            cmd.Parameters.AddWithValue("@quiz", "0");
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                elabel.ForeColor = System.Drawing.Color.Red;
                elabel.Text = err.Message;
            }
            finally
            {
                con.Close();
                name.Text = "";
                pass.Text = "";
                cpass.Text = "";
                email.Text = "";
            }
        }
    }
}