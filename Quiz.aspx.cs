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
    public partial class Quiz : System.Web.UI.Page
    {
        public int points = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["quiz"];
            quiztitle.InnerText = name;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from QuizData where name=@name", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    ListItem li = new ListItem();
                    e1.Text = dt.Rows[0]["e1"].ToString();
                    e2.Text = dt.Rows[0]["e2"].ToString();
                    e3.Text = dt.Rows[0]["e3"].ToString();
                    e4.Text = dt.Rows[0]["e4"].ToString();
                    e5.Text = dt.Rows[0]["e5"].ToString();
                    Intrebare1.Items.Add(dt.Rows[0]["v11"].ToString());
                    Intrebare1.Items.Add(dt.Rows[0]["v12"].ToString());
                    Intrebare1.Items.Add(dt.Rows[0]["v13"].ToString());
                    Intrebare1.Items.Add(dt.Rows[0]["v14"].ToString());
                    Intrebare1.Items.Add(dt.Rows[0]["v15"].ToString());
                    Intrebare2.Items.Add(dt.Rows[0]["v21"].ToString());
                    Intrebare2.Items.Add(dt.Rows[0]["v22"].ToString());
                    Intrebare2.Items.Add(dt.Rows[0]["v23"].ToString());
                    Intrebare2.Items.Add(dt.Rows[0]["v24"].ToString());
                    Intrebare2.Items.Add(dt.Rows[0]["v25"].ToString());
                    Intrebare3.Items.Add(dt.Rows[0]["v31"].ToString());
                    Intrebare3.Items.Add(dt.Rows[0]["v32"].ToString());
                    Intrebare3.Items.Add(dt.Rows[0]["v33"].ToString());
                    Intrebare3.Items.Add(dt.Rows[0]["v34"].ToString());
                    Intrebare3.Items.Add(dt.Rows[0]["v35"].ToString());
                    Intrebare4.Items.Add(dt.Rows[0]["v41"].ToString());
                    Intrebare4.Items.Add(dt.Rows[0]["v42"].ToString());
                    Intrebare4.Items.Add(dt.Rows[0]["v43"].ToString());
                    Intrebare4.Items.Add(dt.Rows[0]["v44"].ToString());
                    Intrebare4.Items.Add(dt.Rows[0]["v45"].ToString());
                    Intrebare5.Items.Add(dt.Rows[0]["v51"].ToString());
                    Intrebare5.Items.Add(dt.Rows[0]["v52"].ToString());
                    Intrebare5.Items.Add(dt.Rows[0]["v53"].ToString());
                    Intrebare5.Items.Add(dt.Rows[0]["v54"].ToString());
                    Intrebare5.Items.Add(dt.Rows[0]["v55"].ToString());
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        protected void trim_Click(object sender, EventArgs e)
        {
            points = 0;
            string name = Request.QueryString["quiz"];
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from QuizData where name=@name", con);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@name", name);

                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (Intrebare1.SelectedItem.Text == dt.Rows[0]["vc1"].ToString()) 
                    {
                        points++;
                    }
                    if (Intrebare2.SelectedItem.Text == dt.Rows[0]["vc2"].ToString())
                    {
                        points++;
                    }
                    if (Intrebare3.SelectedItem.Text == dt.Rows[0]["vc3"].ToString())
                    {
                        points++;
                    }
                    if (Intrebare4.SelectedItem.Text == dt.Rows[0]["vc4"].ToString())
                    {
                        points++;
                    }
                    if (Intrebare5.SelectedItem.Text == dt.Rows[0]["vc5"].ToString())
                    {
                        points++;
                    }
                    points *= 2;
                    if (Request.QueryString["type"]!="test")
                    Response.Redirect("Rezultat.aspx?name=" + name + "&rez=" + points);
                    else Response.Redirect("Rezultat.aspx?name=" + name + "&rez=" + points + "&type=test&nume=" + Request.QueryString["tname"]);
                }
            }
            catch
            {

            }
        }
    }
}