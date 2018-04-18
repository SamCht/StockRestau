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
        private string connectionString = @"Data Source=C:\Users\Vesti\Documents\StockRestauDB.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public static List<Plat> GetAllPlats()
        {
            List<Plat> langs = new List<Plat>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Language WHERE Id = " + langId;
                    if (langId == 0)
                    {
                        sql = "SELECT * FROM Language";
                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Language la = new Language();
                                la.LangTitle = reader["LangTitle"].ToString();
                                la.Id = Int32.Parse(reader["Id"].ToString());
                                langs.Add(la);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
        ...
    }
            return langs;
        }
    }
}
