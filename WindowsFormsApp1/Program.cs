using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]

        static int Rechercher(List<Plat> L, String plat)             //fonction qui permet de vérifier l'existence d'un plat
        {
            int p = -1;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Nom == plat)
                {
                    p = i;
                    break;
                }
            }
            return p;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
