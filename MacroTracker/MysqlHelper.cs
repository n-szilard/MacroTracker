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
                    Console.WriteLine("Sikeres insert!");
                }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Hiba az insert közben: {error.Message}");
            }
        }


    }
}
