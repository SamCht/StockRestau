using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WindowsFormsApp1.DAO
{
    public class DAO
    {
        private static string connectionString = @"Data Source=C:\Users\Vesti\Documents\StockRestauDB.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public static List<Plat> GetAllPlats()
        {
            List<Plat> listePlats = new List<Plat>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Plat";
      
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Plat pl= new Plat();
                                pl.Nom = reader["nom"].ToString();
                                pl.Prix = reader["prix"].ToString();
                                pl.Quantite = reader["quantite"].ToString();

                                listePlats.Add(pl);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
                e.GetBaseException();
            }

            return listePlats;
        }

        public static void addPlat(Plat c)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Plat VALUES (" + id + "," + nom + "," + prix + "," + quantite + ")";
            }
        }
    }
}
