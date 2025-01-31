using MacroTracker;

internal class Program
{

    private static void Main(string[] args)
    {
        List<Kaja> kajaLista = Beolvaso.Beolvasas();
        //KevesKaloriaKajak(kajaLista);
        //HusokTaperteke(kajaLista);
        //ZoldsegekTaperteke(kajaLista);
        //MysqlHelper.KapcsolodasAdatbazishoz();
        //AdatbazisInsert(kajaLista);
        //AdatokKiirasa(kajaLista);
        //Sortores();
        //Etelfelvetel();
        //Sortores();
        //MagasKaloriaKajak(kajaLista);
        //Sortores();
        Menu(kajaLista);
        //LegkaloriasabbAlkoholok(kajaLista);


        
    }

    private static void LegkaloriasabbAlkoholok(List<Kaja> kajaLista)
    {
        Console.WriteLine("Legkalóriadúsabb italok:");
        Sortores();
        foreach (var item in kajaLista)
        {
            if (item.Kategoria == "Drinks Alcohol Beverages" && item.Kaloria>150)
            {
                Console.WriteLine(item.ToString());
            }
        }
        Sortores();
    }

    private static void Menu(List<Kaja> kajaLista)
    {
        string userInput = "";
        while (userInput != "0")
        {
            MenuSzovegKiiras(ref userInput);
            switch (userInput)
            {
                case "0":
                    break;
                case "1":
                    Etelfelvetel();
                    break;
                case "2":
                    MagasKaloriaKajak(kajaLista);
                    break;
                case "3":
                    AdatokKiirasa(kajaLista);
                    break;
                case "4":
                    MysqlHelper.KapcsolodasAdatbazishoz();
                    break;
                case "5":
                    AdatbazisInsert(kajaLista);
                    break;
                case "6":
                    ZoldsegekTaperteke(kajaLista);
                    break;
                case "7":
                    HusokTaperteke(kajaLista);
                    break;
                case "8":
                    KevesKaloriaKajak(kajaLista);
                    break;
                case "9":
                    LegkaloriasabbAlkoholok(kajaLista);
                    break;
                default:
                    Console.WriteLine("Nem értem mit szeretnél :(");
                    break;
            }
        }
    }


    private static void ZoldsegekTaperteke(List<Kaja> lista)
    {
        Console.WriteLine("Összes zöldségféle tápértéke:");
        Sortores();
        foreach (var item in lista)
        {
            if (item.Kategoria == "Vegetables")
            {
                Console.WriteLine(item.ToString());
            }
        }
        Sortores();
    }

    private static void HusokTaperteke(List<Kaja> lista)
    {
        Console.WriteLine("Összes hús és tápértéke:");
        Sortores();
        foreach (var item in lista)
        {
            if (item.Kategoria == "Meat Poultry")
            {
                Console.WriteLine(item.ToString());
            }
        }
        Sortores();
    }
        

    private static void KevesKaloriaKajak(List<Kaja> lista)
    {
        Console.WriteLine("Ételek melyekben legfeljebb 50 kalória van");
        Sortores();
        foreach (var item in lista)
        {
            if (item.Kaloria <= 50)
            {
                Console.WriteLine(item.ToString());
            }
        }
        Sortores();
    }

    private static void MenuSzovegKiiras(ref string userInput)
    {
        string menuSzoveg = @$"
Üdv a programunkban {Environment.UserName}!
1 - Ételfelvétel
2 - Magas kalóriatartalmú ételek listázása
3 - Összes adat kiírása
4 - Kapcsolódás az adatbázishoz
5 - Adatok feltöltése a kívánt táblába
6 - Zöldségek tápértékeinek kiírása
7 - Húsok tápértékeinek kiírása
8 - Ételek kevés kalóriával kiírása
9 - Legtöbb kalóriával rendelkező italok kiírása
0 - EXIT
Írd be a kivánt műveleted és üss egy entert: ";
        Console.Write(menuSzoveg);
        userInput = Console.ReadLine();
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
        Sortores();
    }

    private static void Sortores()
    {
        Console.WriteLine("------------------------------------------");
    }
    private static void AdatbazisInsert(List<Kaja> kajaLista)
    {
        Console.Write("Melyik tablába szeretnéd feltölteni az adatokat (MacroAdatbazis nevű adatbázisban): ");
        string tableName = Console.ReadLine();
        foreach (var item in kajaLista)
        {
            MysqlHelper.TableInsert(tableName, item.toInsertFormat());
        }
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