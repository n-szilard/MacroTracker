using MacroTracker;

internal class Program
{

    private static void Main(string[] args)
    {
        List<Kaja> kajaLista = Beolvaso.Beolvasas();
        AdatokKiirasa(kajaLista);
        //Etelfelvetel();


    }

    private static void Etelfelvetel()
    {
        Console.WriteLine("----Kaja felvétel----");
        Console.WriteLine("Add meg a kaja nevét!");
        string felvettnev=Console.ReadLine();
        Console.WriteLine("Add meg a kaja grammját!");
        string felvettgram = Console.ReadLine();
        Console.WriteLine("Add meg a kaja kaloriáját!");
        string felvettkaloria = Console.ReadLine();
        Console.WriteLine("Add meg a kaja fehérjéjét!");
        string felvettfeherje = Console.ReadLine();
        Console.WriteLine("Add meg a kaja zsírját!");
        string felvettzsir = Console.ReadLine();

    }


    private static void AdatokKiirasa(List<Kaja> lista)
    {
        foreach (var item in lista)
        {
            Console.WriteLine(item.ToString());
        }
    }

}