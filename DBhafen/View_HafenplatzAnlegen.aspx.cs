using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace DBhafen
{
    public partial class View_HafenplatzAnlegen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnHafenplazAnlegenHafenplatzAnlegen_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string insert = "insert into Anlegeplatz (Name, Bemerkung) values(@Name,@Bemerkung)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@Name", TxtBxHafenplatzName.Text);
            cmd.Parameters.AddWithValue("@Bemerkung", TxtBxHafenplatzBemerkung.Text);
            cmd.ExecuteNonQuery();
            con.Close();         
        }

        protected void TxtBxHafenplatzName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}