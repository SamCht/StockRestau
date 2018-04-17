using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int Rechercher(List<Plat> L, String nom)             //fonction qui permet de vérifier l'existence d'un plat
        {
            int p = 0;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].Nom == nom)
                {
                    p = 1;
                    break;
                }
            }
            return p;
        }
        List<Plat> listeP = new List<Plat>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int P = Rechercher(listeP, nomR.Text);
            if(P == 0){
                MessageBox.Show("Le plat n'existe pas.");
            } else
            {
                MessageBox.Show("Le plat existe.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plat p = new Plat(nomAj.Text, prixAj.Text, qteAj.Text);
            
            listeP.Add(p);
            MessageBox.Show(p.Quantite + " plats " + p.Nom + " au prix de " + p.Prix + " ont bien été enregistrés.");
        }
    }
}
