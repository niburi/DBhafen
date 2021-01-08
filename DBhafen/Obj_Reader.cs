using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace DBhafen
{
    public class Obj_Reader
    {

        public List<Obj_Schiff> Get_Schiffe_ToList()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string select = "select * from Schiffe";

            List<Obj_Schiff> ResultSet = new List<Obj_Schiff>();
            using (con)
            {
                SqlCommand command = new SqlCommand(select, con);                
                SqlDataReader reader = command.ExecuteReader();         

                while (reader.Read())
                {
                    var ws = new Obj_Schiff();
                    ws.IdSchiff = reader.GetInt32(0);
                    ws.NameSchiff = reader.GetString(1);
                    ws.bemerkung = reader.GetString(2);
                    ws.Kapitän = reader.GetString(3);

                    ResultSet.Add(ws);
                }
                con.Close();
                return ResultSet;

            }

        }


        public List<Obj_Hafenplatz> get_Hafenplätze_ToList()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string select = "select * from Anlegeplatz";

            List<Obj_Hafenplatz> ResultSet = new List<Obj_Hafenplatz>();

            using (con)
            {

                SqlCommand command = new SqlCommand(select, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var ws = new Obj_Hafenplatz();
                    ws.IdHafenplatz = reader.GetInt32(0);
                    ws.Name = reader.GetString(1);
                    ws.Bemerkung = reader.GetString(2);

                    ResultSet.Add(ws);
                }
                con.Close();
                return ResultSet;
            }
        }





        public List<Obj_AnlageTabelle> get_AnlageTabelleToList()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
            con.Open();
            string select = "select * from AnlageTabelle";

            List<Obj_AnlageTabelle> ResultSet = new List<Obj_AnlageTabelle>();
            using (con)
            {
                SqlCommand command = new SqlCommand(select, con);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var ws = new Obj_AnlageTabelle();
                    ws.IdBuchung = reader.GetInt32(0);
                    ws.buchungVon = reader.GetDateTime(1);
                    ws.buchungBis = reader.GetDateTime(2);
                    ws.bemerkung = reader.GetString(3);
                    ws.fk_IdAnlegeplatz = reader.GetInt32(4);
                    ws.fk_IdSchiff = reader.GetInt32(5);

                    ResultSet.Add(ws);
                }
                con.Close();
                return ResultSet;
            }
        }


    }

}