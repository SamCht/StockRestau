using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Plat
    {
        private string nom;
        private double prix;
        private int quantite;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }

        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }


        public Plat() { }
        public Plat(string no, double px, int qt)
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
