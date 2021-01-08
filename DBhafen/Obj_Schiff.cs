using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBhafen
{
    public class Obj_Schiff
    {
        public int IdSchiff;
        public string NameSchiff;
        public string bemerkung;
        public string Kapitän;

        //Get Methoden
        public int get_IdSchiff()
        {
            return IdSchiff;

        }
        public string get_NameSchiff()
        {
            return NameSchiff;
        }
        public string get_Bemerkung()
        {
            return bemerkung;
        }
        public string get_Kapitän()
        {
            return Kapitän;
        }


        //Set Methoden
        public void set_IdSchiff( int IdSchiff)
        {
            this.IdSchiff = IdSchiff;
        }
        public void set_nameSchiff (String nameSchiff)
        {
            this.NameSchiff = nameSchiff;
        }
        public void set_bemerkung(String bemerkung)
        {
            this.bemerkung = bemerkung;
        }
        public void set_Kapitän(String kapitän)
        {
            this.Kapitän = kapitän;
        }
         

    }
}