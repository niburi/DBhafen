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
    public partial class View_HafenplatzBuchen : System.Web.UI.Page
    {
        private String anlegeplaetzeID;
        private String schiffeID;

        protected void Page_Load(object sender, EventArgs e)
        {
            


            //Datumslabel von
            if (CalendarVon.SelectedDate.ToShortDateString() == "01.01.0001")
            {
                Lbl_SelVon.Text = "";
            }
            else
            {
                Lbl_SelVon.Text = CalendarVon.SelectedDate.ToShortDateString();
            }


            //Datumslabel Bis 
            if (CalendarBis.SelectedDate.ToShortDateString() == "01.01.0001") {
                Lbl_SelBis.Text = "";
            }
            else
            {
                Lbl_SelBis.Text = CalendarBis.SelectedDate.ToShortDateString();
            }



            //Warnungslabel Settings
            if (DateTime.Compare(CalendarBis.SelectedDate, CalendarVon.SelectedDate) < 0)
            {
                LblWarnung.Text = "Buchung nicht möglich da das Bis Datum größer als das von Datum ist";
                LblWarnung.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                LblWarnung.Text = "";
                LblWarnung.BackColor = System.Drawing.Color.White;
            }

            
        }

        protected void BtnHafenplatzBuchenBuchen_Click(object sender, EventArgs e)
        {
            //wenn keine datum anomalie 
            if (LblWarnung.BackColor != System.Drawing.Color.Yellow)
            {

                //Selected Value AnlegeplatzID
                for (int i = 0; i < CheckBoxAnlegeplätze.Items.Count; i++)
                {
                    if (CheckBoxAnlegeplätze.Items[i].Selected)
                    {
                        anlegeplaetzeID = CheckBoxAnlegeplätze.Items[i].Value;
                    }
                }

                //Selected Value SchiffeID
                for (int i = 0; i < CheckBoxSchiffe.Items.Count; i++)
                {
                    if (CheckBoxSchiffe.Items[i].Selected)
                    {
                        schiffeID = CheckBoxSchiffe.Items[i].Value;
                    }
                }

                //Daten aus Datenbank holen
                Obj_Reader reader = new Obj_Reader();
                List<Obj_Schiff> schiffe = new List<Obj_Schiff>();
                List<Obj_AnlageTabelle> AnlageTabelle = new List<Obj_AnlageTabelle>();

                TimeSpan test;
                for (int i = 0; i == AnlageTabelle.Count()-1; i++ )
                {
                    test = AnlageTabelle[i].get_IntervalCheck();
                }


                try
                {
                    schiffe = reader.Get_Schiffe_ToList();
                    AnlageTabelle = reader.get_AnlageTabelleToList();
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
                bool chk = false;
                //wenn mehr als 0 Datensätze da sind 
                if (AnlageTabelle.Count() != 0)
                {
                    for (int i = 0; i <= AnlageTabelle.Count() - 1; i++)
                    {
                        if (AnlageTabelle[i].get_fk_IdAnlegeplatz().ToString() == anlegeplaetzeID)
                        {
                            //Datum darf nicht in Intervall von gebuchten Daten liegen

                            //Kleiner als 0(null) datum 1 liegt vor datum 2
                            //Zero datum 1 entspricht Datum 2
                            //größer als 0 (null) datum 1 ist später als datum 2
                            if (DateTime.Compare(CalendarVon.SelectedDate, AnlageTabelle[i].get_BuchungVon() ) >= 0 && DateTime.Compare(CalendarVon.SelectedDate, AnlageTabelle[i].get_BuchungBis()) <= 0 ||
                                DateTime.Compare(CalendarVon.SelectedDate, AnlageTabelle[i].get_BuchungBis() ) <= 0 && DateTime.Compare(CalendarVon.SelectedDate, AnlageTabelle[i].get_BuchungVon() ) >= 0 ||
                                DateTime.Compare(CalendarBis.SelectedDate, AnlageTabelle[i].get_BuchungVon()  ) >= 0 && DateTime.Compare(CalendarBis.SelectedDate, AnlageTabelle[i].get_BuchungBis()) <= 0) 
                            {
                                LblWarnung.Text = "Hafenplatz ist bereits belegt";
                                LblWarnung.BackColor = System.Drawing.Color.Yellow;
                                chk = true;
                            }
                        }
                    }
                }
                if (chk == false)
                    {
                    //SQL Insert statement                
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ConnectionString);
                    con.Open();
                    string insert = "insert into AnlageTabelle (GebuchtVon, GebuchtBis, Bemerkung, FK_IDAnlegeplatz, FK_IDSchiff) values(@GebuchtVon,@GebuchtBis,@Bemerkung,@Fk_IDAnlegeplatz,@FK_IDSchiff)";
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.Parameters.AddWithValue("@GebuchtVon", CalendarVon.SelectedDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@GebuchtBis", CalendarBis.SelectedDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Bemerkung", TxtBxBemerkung.Text);
                    cmd.Parameters.AddWithValue("@FK_IDAnlegeplatz", anlegeplaetzeID);
                    cmd.Parameters.AddWithValue("@FK_IDSchiff", schiffeID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    LblWarnung.Text = "Buchung erfolgreich";
                    LblWarnung.BackColor = System.Drawing.Color.Green;
                }               
                else
                {
                 
                }                
            }
                        
        }

        protected void CalendarVon_SelectionChanged(object sender, EventArgs e)
        {
            Lbl_SelVon.Text = CalendarVon.SelectedDate.ToShortDateString();
            if (DateTime.Compare(CalendarBis.SelectedDate, CalendarVon.SelectedDate) < 0)
            {
                LblWarnung.Text = "Buchung nicht möglich da das Bis Datum größer als das von Datum ist";
                LblWarnung.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                LblWarnung.Text = "";
                LblWarnung.BackColor = System.Drawing.Color.White;
            }
        }

        protected void CalendarBis_SelectionChanged(object sender, EventArgs e)
        {
            Lbl_SelBis.Text = CalendarBis.SelectedDate.ToShortDateString();
            if (DateTime.Compare(CalendarBis.SelectedDate, CalendarVon.SelectedDate) < 0)
            {
                LblWarnung.Text = "Buchung nicht möglich da das Bis Datum größer als das von Datum ist";
                LblWarnung.BackColor = System.Drawing.Color.Yellow;
            }
            else
            {
                LblWarnung.Text = "";
                LblWarnung.BackColor = System.Drawing.Color.White;
            }
        }

        protected void CheckBoxSchiffe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}