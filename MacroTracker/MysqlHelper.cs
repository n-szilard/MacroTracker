using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroTracker
{
    internal class MysqlHelper
    {
        private static string connectionString = "Server=localhost;Database=MacroAdatbazis;User id=root;password=;";
        private static MySqlConnection connection = new MySqlConnection(connectionString);

        public static void KapcsolodasAdatbazishoz()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Kapcsolat sikeresen megnyitva.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba a kapcsolat megnyitásakor: " + ex.Message);
            }
        }

        public static void TableInsert(string tableName, string values)
        {
            try
            {
                using (MySqlCommand command = new MySqlCommand($"INSERT INTO {tableName} VALUES ({values})", connection))
                {
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Sikeres insert!");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hiba az insert közben: {error.Message}");
            }
        }

        public static void CreateTable(string tableName)
        {
            string tableFormat = $"CREATE TABLE `{tableName}` (`Nev` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL, `KulfMertek` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL, `Gram` int(11) NOT NULL, `Kaloria` int(11) NOT NULL, `Feherje` int(11) NOT NULL, `Zsir` int(11) NOT NULL, `TelitettZsir` int(11) NOT NULL, `Rost` int(11) NOT NULL, `Szenhidrat` int(11) NOT NULL, `Kategoria` varchar(50) CHARACTER SET utf8 COLLATE utf8_hungarian_ci NOT NULL)";
            try
            {
                using (MySqlCommand command = new MySqlCommand(tableFormat, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Sikeres tábla létrehozás");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hiba a tábla létrehozása közben: {error.Message}");
            }
        }


    }
}
