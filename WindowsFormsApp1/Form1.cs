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
       static Plat Rechercher(List<Plat> pl, String nom)
        {
            platDAO acces = new platDAO();
            pl = acces.GetAllPlats();
            foreach (Plat p in pl)
            {
                if (p.Nom == nom)
                {
                    return p;
                }
            }

            return null;
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
            Plat p = Rechercher(listeP, nomR.Text);
            if(p == null){
                MessageBox.Show("Le plat n'existe pas.");
            } else
            {
                MessageBox.Show("Le plat existe.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Plat p = new Plat(nomAj.Text, prixAj.Text, qteAj.Text);
            //listeP.Add(p);
            //MessageBox.Show(p.Quantite + " plats " + p.Nom + " au prix de " + p.Prix + " ont bien été enregistrés.");
            platDAO plat = new platDAO();
            int result = plat.addPlat(nomAj.Text, prixAj.Text, qteAj.Text);
            if(result == -1)
            {
                MessageBox.Show("NTM");
            } else
            {
                MessageBox.Show("Bien");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if(Rechercher(listeP,nomSup.Text) != null)
             {
                 listeP.Remove(Rechercher(listeP, nomSup.Text));
                 MessageBox.Show("Le plat a été supprimé");
             }
             else
             {
                 MessageBox.Show("Impossible de supprimé le plat car il n'existe pas");
             }*/
            platDAO acces = new platDAO();
            int result = acces.deletePlat(nomSup.Text);
            if (result == -1)
            {
                MessageBox.Show("NTM");
            }
            else
            {
                MessageBox.Show("Bien");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            platDAO acces = new platDAO();
            listeP = acces.GetAllPlats();
            TousPlatsView monForm = new TousPlatsView(listeP);
            monForm.Show();
        }
    }
}
