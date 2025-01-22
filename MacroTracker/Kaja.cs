using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroTracker
{
    internal class Kaja
    {
        public string KajaNev { get; set; }

        public string KajaKulfMertek { get; set; }

        public int Gram { get; set; }

        public int Kaloria { get; set; }

        public int Feherje { get; set; }

        public int Zsir { get; set; }

        public int TelitettZsir { get; set; }

        public int Rost { get; set; }

        public int Szenhidrat { get; set; }

        public string Kategoria { get; set; }

        public Kaja(string kajaNev, string kajaKulfMertek, int gram, int kaloria, int feherje, int zsir, int telitettZsir, int rost, int szenhidrat, string kategoria)
        {
            KajaNev = kajaNev;
            KajaKulfMertek = kajaKulfMertek;
            Gram = gram;
            Kaloria = kaloria;
            Feherje = feherje;
            Zsir = zsir;
            TelitettZsir = telitettZsir;
            Rost = rost;
            Szenhidrat = szenhidrat;
            Kategoria = kategoria;
        }

        public Kaja(string kajaNev, int gram, int kaloria, string kategoria)
        {
            KajaNev = kajaNev;
            Gram = gram;
            Kaloria = kaloria;
            Kategoria = kategoria;  
        }

        public override string ToString()
        {
            return $"Étel neve: {KajaNev}, Gram: {Gram}, Kalória: {Kaloria}, Fehérje: {Feherje}, Zsír: {Zsir}, Telitett zsír: {TelitettZsir}, Rost: {Rost}, Szénhidrát: {Szenhidrat}, Étel kategóriája: {Kategoria}";
        }
        

    }
}
