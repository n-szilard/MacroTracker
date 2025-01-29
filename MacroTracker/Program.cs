using MacroTracker;
using System.Reflection.Emit;

internal class Program
{

    private static void Main(string[] args)
    {
        List<Kaja> kajaLista = Beolvaso.Beolvasas();
        AdatokKiirasa(kajaLista);
        Sortores();

        Etelfelvetel();
        Sortores();
        MagasKaloriaKajak(kajaLista);
        Sortores();

    }

    private static void MagasKaloriaKajak(List<Kaja> lista)
    {
        Console.WriteLine("Ételek melyekben 800-nál több kalória van");
        Sortores();
        foreach (var item in lista)
        {
            if (item.Kaloria >= 800)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    private static void Sortores()
    {
        Console.WriteLine("------------------------------------------");
    }

    private static void Etelfelvetel()
    {
        Console.WriteLine("----Kaja felvétel----");
        Console.WriteLine("Szeretnél ételt felvenni? (igen/nem)");

        string felvetelvagynem =Console.ReadLine();
        if (felvetelvagynem=="igen")
        {
            Console.WriteLine("Add meg a kaja nevét!");
            string felvettnev = Console.ReadLine();
            Console.WriteLine("Add meg a kaja grammját!");
            string felvettgram = Console.ReadLine();
            Console.WriteLine("Add meg a kaja kaloriáját!");
            string felvettkaloria = Console.ReadLine();
            Console.WriteLine("Add meg a kaja fehérjéjét!");
            string felvettfeherje = Console.ReadLine();
            Console.WriteLine("Add meg a kaja zsírját!");
            string felvettzsir = Console.ReadLine();
        }
        Console.WriteLine("----Kaja felvétel vége----");
        
        

    }


    private static void AdatokKiirasa(List<Kaja> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

}