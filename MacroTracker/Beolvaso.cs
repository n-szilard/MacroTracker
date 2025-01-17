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


        public static void Beolvasas()
        {
            StreamReader streamReader = new StreamReader(fajlNev);
            try
            {
                if (SkipElsoSor)
                {
                    streamReader.ReadLine();
                }

                List<string> sorok = new List<string>();
                while (!streamReader.EndOfStream)
                {
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
