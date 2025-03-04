using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wynalazki.model
{
    internal class Wynalazek
    {
        public int Numer_zgloszenia {  get; set; }
        public int? Numer_prawa_wylacznego { get; set; }
        public DateTime? Data_pierwszenstwa { get; set; }
        public DateTime? Data_zgloszenia { get; set; }
        public string Numer_BUP { get; set; }
        public DateTime? Data_Publikacji_BUP { get; set; }
        public string Numer_WUP { get; set; }
        public DateTime? Data_Publikacji_WUP { get; set; }
        public string Tytul { get; set; }
        public string Uprawnieni { get; set; }
        public string Tworcy { get; set; }
        public string Pelnomocnicy { get; set; }
        public string Klasyfikacja_MKP { get; set; }
        public string Status_sprawy { get; set; }




    }
}
