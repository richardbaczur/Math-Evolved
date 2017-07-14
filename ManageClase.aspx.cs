using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;

namespace INfoEducatie
{
    public partial class ManageClase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clase WHERE Profesor=@prof", con);
            cmd.Parameters.AddWithValue("@prof", INfoEducatie.LogInProf.name);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cls.Items.Add(dt.Rows[i]["Nume"].ToString());
                    string[] elevi = dt.Rows[i]["Elevi"].ToString().Split(',');
                }
            }
            del.Items.Clear();

        }

        protected void select_Click(object sender, EventArgs e)
        {
            nume.Enabled = true;
            del.Enabled = true;
            dele.Enabled = true;
            add.Enabled = true;
            nCls.InnerText = cls.Text;
            cls.Items.Clear();
            del.Items.Clear();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clase WHERE Nume=@name", con);
            cmd.Parameters.AddWithValue("@name", nCls.InnerText);
            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string[] elevi = dt.Rows[0]["Elevi"].ToString().Split(',');
                for (int i = 0; i < elevi.Length; i++)
                {
                    del.Items.Add(elevi[i]);
                }
            }
            
        }

        protected void add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand update = new SqlCommand("UPDATE Clase SET Elevi=@nquiz WHERE Nume=@name", con);
            SqlCommand extragere = new SqlCommand("SELECT Elevi FROM Clase WHERE Nume=@name", con);
            extragere.Parameters.AddWithValue("@name", nCls.InnerText);
            update.Parameters.AddWithValue("@name", nCls.InnerText);
            con.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(extragere))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string[] aux = dt.Rows[0]["Elevi"].ToString().Split(',');
                 
                if (dt.Rows[0]["Elevi"].ToString() == "" || dt.Rows[0]["Elevi"].ToString() == null)
                {
                    update.Parameters.AddWithValue("@nquiz", nume.Text);
                }
                else
                {
                    update.Parameters.AddWithValue("@nquiz", dt.Rows[0]["Elevi"] + "," + nume.Text);
                }
                update.ExecuteNonQuery();
            }
            con.Close();
        }

        protected void dele_Click(object sender, EventArgs e)
        {
            string nm = nume.Text;
            cls.Items.Clear();
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            SqlCommand ins = new SqlCommand("UPDATE Clase SET Elevi = Elevi + @elevinou WHERE Nume=@name", con);
            ins.Parameters.AddWithValue("@elevinou", nm+",");
            ins.Parameters.AddWithValue("@name", nCls.InnerText);
            con.Open();
            ins.ExecuteNonQuery();
            con.Close();
            Page_Load(null, null);
        }
    }
}