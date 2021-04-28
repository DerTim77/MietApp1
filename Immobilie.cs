using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MietApp1
{
    public abstract class Immobilie
    {
        public string Strasse { get; set; }
        public string Hausnummer { get; set; }
        public string PLZ { get; set; }
        public string Ort { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime EndDatum { get; set; } 
        public int Raumanzahl { get; set; }
        public double Groesse { get; set; }
        public double PreisProQM { get; set; }
        public double Mietpreis { get; set; } 

        public abstract double BerechneMiete();
    }
    public class WohnImmobilie : Immobilie
    {
        public bool Keller { get; set; }
        public bool Einbauküche { get; set; }
        public bool Waschmaschine { get; set; }
        public bool Balkon { get; set; }
        public bool Dachboden { get; set; }
        public bool Parkplatz { get; set; }
        public ImmobilienArtWohnen Art { get; set; }
        public override double BerechneMiete()
        {
            return 0;
        }
    }
    public class GewerbeImmobilie : Immobilie
    {
        public ImmobilienArtGewerbe Nutzungsart { get; set; }
        public int AnzahlParkplaetze { get; set; }
        public override double BerechneMiete()
        {
            return 0;
        }
    }
    public enum ImmobilienArtWohnen { Wohnung, Haus, WGZimmer}
    //enum = intern integer
    public enum ImmobilienArtGewerbe { Lagerhaus, Büro, Restaurant, Sonstiges }
}
