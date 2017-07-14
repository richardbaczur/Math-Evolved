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
    public partial class RegisterProfi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO ProvisionalProfi VALUES(@name,@pass,@email,@inst,@img)", con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@inst", inst.Text); 
            cmd.Parameters.AddWithValue("@img", "");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}