using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Plat
    {
        private string nom;
        private string prix;
        private string quantite;
    

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public string Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }


        public Plat() { }
        public Plat(string no, string px, string qt)
        {
            nom = no;
            prix = px;
            quantite = qt;
        }
        public override string ToString()
        {
            return "\r\nNom: " + nom + "\r\nPrix: " + prix + "\r\nQuantité: " + quantite;
        }
  
    }
}
