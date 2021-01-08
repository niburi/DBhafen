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
    public partial class WebViewFirst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        protected void BtnSchiffAnlegen_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                con.Open();
                string insert = "insert into schiffe (NameSchiff, Bemerkung, Kapitän) values(@NameSchiff,@Bemerkung,@Kapitän)";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@NameSchiff", TxtBxNameSchiff.Text);
                cmd.Parameters.AddWithValue("@Bemerkung", TxtBxBemerkung.Text);
                cmd.Parameters.AddWithValue("@Kapitän", TxtBxKapitän.Text);
                cmd.ExecuteNonQuery();
                //Response.Redirect("home.aspx");

                //Entferne Inhalt von Tabelle
                //string del = "TRUNCATE TABLE Schiffe";
                //SqlCommand cmd = new SqlCommand (del, con);
                //cmd.ExecuteNonQuery();
                con.Close();
                
                
                Response.Redirect("View_schiffAnlegen.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TxtBxBemerkung_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ToDo Change item in database
            // tabellenindex 
            int indexSchiff = GridView1.SelectedRow.RowIndex + 1;
            Obj_Reader read = new Obj_Reader();
            List<Obj_Schiff> schiffe = new List<Obj_Schiff>();

            try
            {
           
                schiffe = read.Get_Schiffe_ToList();
                LblIndex.Text = schiffe[indexSchiff-1].get_IdSchiff().ToString();
                TxtBxBemer.Text = schiffe[indexSchiff - 1].get_Bemerkung();
                TxtBxNamSchif.Text = schiffe[indexSchiff - 1].get_NameSchiff();
                TxtBxKptn.Text = schiffe[indexSchiff - 1].get_Kapitän();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void BtnChange_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}