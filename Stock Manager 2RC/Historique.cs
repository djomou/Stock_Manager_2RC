using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Manager_2RC
{
    public partial class Historique : Form
    {
        Fonctions Con;
        public Historique()
        {
            InitializeComponent();
            Con = new Fonctions();
            ListerArticles();
        }
        private void ListerArticles()
        {
            string Req = "Select * from TblHistorique";
           ListeEnregistrement.DataSource = Con.RecupererDonnees(Req);
        }

        private void BntRetour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articles BacktoArticles = new Articles();
            BacktoArticles.Show();
            this.Hide();
        }
    }
}
