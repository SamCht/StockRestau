using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WindowsFormsApp1.DAO
{
       public interface DAO<T>
       {
            List<T> GetAllPlats();
            int addPlat(String nom, String prix, String quantite);
            int deletePlat(String unNom);
       }
}
