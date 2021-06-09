using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ЕИТ_А12
{
    public partial class Pocetna : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LNDO9G;Initial Catalog=A-12;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand insert = new SqlCommand("insert into Utisak VALUES(@ime,@email,@komentar,CAST(GETDATE() AS Date))",con);
            insert.Parameters.AddWithValue("@ime", TextBox1.Text);
            insert.Parameters.AddWithValue("@email", TextBox2.Text);
            insert.Parameters.AddWithValue("@komentar", TextBox3.Text);
            con.Open();
            insert.ExecuteNonQuery();
            con.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}