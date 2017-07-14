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
    public partial class TemeClase : System.Web.UI.Page
    {
        //cls - DropdownList pentru selectarea clasei pe care se lucreaza
        //prob - DropdownList pentru selectarea problemei pe care profesorul doreste sa o dea de tema
        protected void Page_Load(object sender, EventArgs e)
        {
            cls.Items.Clear();
            prob.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand clsel = new SqlCommand("SELECT Nume FROM Clase", con);
            SqlCommand pbsel = new SqlCommand("SELECT name FROM Probleme", con);
            using (SqlDataAdapter sda = new SqlDataAdapter(clsel))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cls.Items.Add(dt.Rows[i]["Nume"].ToString());
                }
            }
            using (SqlDataAdapter sda = new SqlDataAdapter(pbsel))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    prob.Items.Add(dt.Rows[i]["name"].ToString());
                }
            }
        }

        protected void sel_Click(object sender, EventArgs e)
        {
            selected.InnerText = cls.Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            if (prob.Text != "" && probleme.InnerText == "") probleme.InnerText += prob.Text;
            else if (prob.Text != "" && probleme.InnerText != "") probleme.InnerText += ", " + prob.Text;
        }

        protected void set_Click(object sender, EventArgs e)
        {
            if (selected.InnerText != "" && probleme.InnerText != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE Clase SET Teme=@tema WHERE Nume=@name", con);
                cmd.Parameters.AddWithValue("@tema", probleme.InnerText);
                cmd.Parameters.AddWithValue("@name", selected.InnerText);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}