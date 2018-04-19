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
    public partial class TousPlatsView : Form
    {
        public TousPlatsView()
        {
            
        }

        public TousPlatsView(List<Plat> pl)
        {
            InitializeComponent();

            foreach (Plat p in pl)
            {
                dataGridView1.Rows.Add(p.Nom, p.Prix, p.Quantite);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
