using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroTracker
{
    internal class Beolvaso
    {
        private static string fajlNev = "../../../Adatok/nutrients.csv";
        private static char Elvalaszto = ',';
        private static bool SkipElsoSor = true;


        public static List<Kaja> Beolvasas()
        {
            StreamReader streamReader = new StreamReader(fajlNev);
            List<Kaja> kajaLista = new List<Kaja>();
            List<string> sorok = new List<string>();
            try
            {
                if (SkipElsoSor)
                {
                    streamReader.ReadLine();
                }

                while (!streamReader.EndOfStream)
                {
                    sorok.Add(streamReader.ReadLine());
                }

                foreach (var sor in sorok)
                {
                    string[] sorElemek = sor.Split(',');
                    foreach (var elem in sorElemek)
                    {
                        
                    }
                    kajaLista.Add(new Kaja(sorElemek[0], sorElemek[1], Convert.ToInt32(sorElemek[2]), Convert.ToInt32(sorElemek[3]), Convert.ToInt32(sorElemek[4]), Convert.ToInt32(sorElemek[5]), Convert.ToInt32(sorElemek[6]), Convert.ToInt32(sorElemek[7]), Convert.ToInt32(sorElemek[8]), sorElemek[9]));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return kajaLista;
        }
    }
}
