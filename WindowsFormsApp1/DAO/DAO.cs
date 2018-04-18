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
        private static string connectionString = @"Data Source=C:\Users\Samuel\Documents\Visual Studio 2017\Projects\StockRestau\StockRestauDB.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

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
                                Plat pl = new Plat();
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

        public static void addPlat(String id, String nom, String prix, String quantite)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Plat(id,nom,prix,quantite) VALUES (@id,@nom,@prix,@quantite)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@id", id, "@nom", nom, "@prix", prix, "@quantite", quantite);
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Plat pl = new Plat();
                            pl.Nom = reader["nom"].ToString();
                            pl.Prix = reader["prix"].ToString();
                            pl.Quantite = reader["quantite"].ToString();
                            
                        }
                    }
                }
            }
        }

        public static void deletePlat(Plat unPlat)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                List<Plat> listePlat = GetAllPlats();
                listePlat.Remove(unPlat);
            }
        }
    }
}
