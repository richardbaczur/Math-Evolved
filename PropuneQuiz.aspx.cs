using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace INfoEducatie
{
    public partial class PropuneQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void trimite_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ricop\Source\Repos\InfoEdu\INfoEducatie\App_Data\date.mdf;Integrated Security=True");
            con.Open();
            SqlCommand adaugareQuiz = new SqlCommand("insert into ProvisionalQuiz VALUES(@name,@desc,@e1,@e2,@e3,@e4,@e5,@v11,@v12,@v13,@v14,@v15,@v21,@v22,@v23,@v24,@v25,@v31,@v32,@v33,@v34,@v35,@v41,@v42,@v43,@v44,@v45,@v51,@v52,@v53,@v54,@v55,@vc1,@vc2,@vc3,@vc4,@vc5)", con);
            adaugareQuiz.Parameters.AddWithValue("@name", name.Text);
            adaugareQuiz.Parameters.AddWithValue("@desc", descr.Text);
            adaugareQuiz.Parameters.AddWithValue("@e1", e1.Text);
            adaugareQuiz.Parameters.AddWithValue("@e2", e2.Text);
            adaugareQuiz.Parameters.AddWithValue("@e3", e3.Text);
            adaugareQuiz.Parameters.AddWithValue("@e4", e4.Text);
            adaugareQuiz.Parameters.AddWithValue("@e5", e5.Text);
            adaugareQuiz.Parameters.AddWithValue("@v11", v11.Text);
            adaugareQuiz.Parameters.AddWithValue("@v12", v12.Text);
            adaugareQuiz.Parameters.AddWithValue("@v13", v13.Text);
            adaugareQuiz.Parameters.AddWithValue("@v14", v14.Text);
            adaugareQuiz.Parameters.AddWithValue("@v15", v15.Text);
            adaugareQuiz.Parameters.AddWithValue("@v21", v21.Text);
            adaugareQuiz.Parameters.AddWithValue("@v22", v22.Text);
            adaugareQuiz.Parameters.AddWithValue("@v23", v23.Text);
            adaugareQuiz.Parameters.AddWithValue("@v24", v24.Text);
            adaugareQuiz.Parameters.AddWithValue("@v25", v25.Text);
            adaugareQuiz.Parameters.AddWithValue("@v31", v31.Text);
            adaugareQuiz.Parameters.AddWithValue("@v32", v32.Text);
            adaugareQuiz.Parameters.AddWithValue("@v33", v33.Text);
            adaugareQuiz.Parameters.AddWithValue("@v34", v34.Text);
            adaugareQuiz.Parameters.AddWithValue("@v35", v35.Text);
            adaugareQuiz.Parameters.AddWithValue("@v41", v41.Text);
            adaugareQuiz.Parameters.AddWithValue("@v42", v42.Text);
            adaugareQuiz.Parameters.AddWithValue("@v43", v43.Text);
            adaugareQuiz.Parameters.AddWithValue("@v44", v44.Text);
            adaugareQuiz.Parameters.AddWithValue("@v45", v45.Text);
            adaugareQuiz.Parameters.AddWithValue("@v51", v51.Text);
            adaugareQuiz.Parameters.AddWithValue("@v52", v52.Text);
            adaugareQuiz.Parameters.AddWithValue("@v53", v53.Text);
            adaugareQuiz.Parameters.AddWithValue("@v54", v54.Text);
            adaugareQuiz.Parameters.AddWithValue("@v55", v55.Text);
            adaugareQuiz.Parameters.AddWithValue("@vc1", Subprograme.getAnswer(vc1.Text, v11.Text, v12.Text, v13.Text, v14.Text, v15.Text));
            adaugareQuiz.Parameters.AddWithValue("@vc2", Subprograme.getAnswer(vc2.Text, v21.Text, v22.Text, v23.Text, v24.Text, v25.Text));
            adaugareQuiz.Parameters.AddWithValue("@vc3", Subprograme.getAnswer(vc3.Text, v31.Text, v32.Text, v33.Text, v34.Text, v35.Text));
            adaugareQuiz.Parameters.AddWithValue("@vc4", Subprograme.getAnswer(vc4.Text, v41.Text, v42.Text, v43.Text, v44.Text, v45.Text));
            adaugareQuiz.Parameters.AddWithValue("@vc5", Subprograme.getAnswer(vc5.Text, v51.Text, v52.Text, v53.Text, v54.Text, v55.Text));
            adaugareQuiz.CommandType = CommandType.Text;
            adaugareQuiz.ExecuteNonQuery();
            con.Close();
        }
    }
}