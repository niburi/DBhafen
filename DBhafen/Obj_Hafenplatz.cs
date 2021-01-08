using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBhafen
{
    public class Obj_Hafenplatz
    {
        public int IdHafenplatz;
        public String Name;
        public String Bemerkung;


        //Get Methoden
        public int get_IdHafenPlatz()
        {
            return IdHafenplatz;
        }
        public String get_Name()
        {
            return Name;
        }
        public String get_Bemerkung()
        {
            return Bemerkung;
        }


        //Set Methoden
        public void set_idHafenplatz(int IdHafenplatz)
        {
            this.IdHafenplatz = IdHafenplatz;
        }
        public void set_Name(String Name)
        {
            this.Name = Name;
        }
        public void set_Bemerkung(String Bemerkung)
        {
            this.Bemerkung = Bemerkung;
        }
    }
}