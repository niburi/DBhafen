using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBhafen
{
    public class Obj_AnlageTabelle
    {
        public int IdBuchung;
        public DateTime buchungVon;
        public DateTime buchungBis;
        public String bemerkung;
        public int fk_IdAnlegeplatz;
        public int fk_IdSchiff;
        public TimeSpan length;

        //Get Methoden
        public int get_IdBuchung()
        {
            return IdBuchung;
        }
        public DateTime get_BuchungVon()
        {
            return buchungVon;
        }
        public DateTime get_BuchungBis()
        {
            return buchungBis;
        }
        public String get_Bemerkung()
        {
            return bemerkung;
        }
        public int get_fk_IdAnlegeplatz()
        {
            return fk_IdAnlegeplatz;
        }

        public int get_fk_IdSchiff()
        {
            return fk_IdSchiff;
        }
        public void get_IdBuchung(int IdBuchung)
        {
            this.IdBuchung = IdBuchung;
        }


        //Set Methoden
        public void get_BuchungVon(DateTime BuchungVon)
        {
            this.buchungVon = BuchungVon;
        }
        public void get_BuchungBis(DateTime BuchungBis)
        {
            this.buchungBis = BuchungBis;
        }
        public void get_Bemerkung(String Bemerkung)
        {
            this.bemerkung = Bemerkung;
        }
        public void get_fk_IdAnlegeplatz(int fk_IdAnlegeplatz)
        {
            this.fk_IdAnlegeplatz = fk_IdAnlegeplatz;
        }
        public void get_fk_IdSchiff(int fk_IdSchiff)
        {
            this.fk_IdSchiff = fk_IdSchiff;
        }



        public TimeSpan get_IntervalCheck()
        {
            TimeSpan i = buchungBis - buchungVon;

            length = buchungBis.Subtract(buchungVon);
            return length;
        }
    }
}