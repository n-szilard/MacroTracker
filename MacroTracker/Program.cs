using MacroTracker;

internal class Program
{

    private static void Main(string[] args)
    {
        //List<Kaja> kajaLista = new List<Kaja>();
        //Beolvaso.Beolvasas();
        /*AdatokKiirasa();            */
        Etelfelvetel();


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
    

    /*private static void AdatokKiirasa()
    {
        foreach(dolog in dolog)
        {
            Console.WriteLine(adat);
        }
    }
    */
}