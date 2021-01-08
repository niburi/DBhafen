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
    public partial class View_MainWindow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnMenueSchiffAnlegen_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_SchiffAnlegen.aspx");
        }

        protected void BtnMenueHafenplatzAnlegen_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_HafenplatzAnlegen.aspx");
        }

        protected void BtnMenueHafenplatzBuchen_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_HafenplatzBuchen.aspx");
        }

        protected void BtnMenueSchiffeAnzeigen_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_SchiffeAnzeigen.aspx");
        }

        protected void BtnMenueBuchungen_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Buchungen.aspx");
        }

        protected void BtnMenueSchiffeDel_Click(object sender, EventArgs e)
        {
            //Entferne Inhalt von Tabelle
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string del = "TRUNCATE TABLE Schiffe";
            SqlCommand cmd = new SqlCommand (del, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void BtnMenueHafenplätzeDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string del = "TRUNCATE TABLE Anlegeplatz";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void BtnMenueBuchungenDel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string del = "TRUNCATE TABLE AnlageTabelle";
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}