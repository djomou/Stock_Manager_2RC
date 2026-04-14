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
    public partial class Ajouter : Form
    {
        Fonctions Con;
        public Ajouter()
        {
            InitializeComponent();
            Con = new Fonctions();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ajoute_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomArt.Text == "" || NomCat.Text == "" || Quantite.Text == "" || Seuil.Text == "")
                {
                    MessageBox.Show("Veuillez vous rassurer que tous les champs ont bien été remplis!");
                }
                else
                {
                    string Nom = NomArt.Text;
                    string Cat = NomCat.Text;
                    int Qnt = Convert.ToInt32(Quantite.Text);
                    int Sl = Convert.ToInt32(Seuil.Text);
                    DateTime Date = ModifDate.Value.Date;
                    string Etat = "Article Ajouté!";
                    string Req1 = "insert into TblArticles values('{0}','{1}','{2}','{3}')";
                    string Req2 = "insert into TblHistorique values('{0}','{1}','{2}','{3}')";
                    Req1 = string.Format(Req1, Nom, Cat, Qnt, Sl);
                    Req2 = string.Format(Req2, Nom, Qnt, Date, Etat);
                    Con.EnvoyerDonnees(Req1);
                    Con.EnvoyerDonnees(Req2);
                    MessageBox.Show("Le Materiel a bien été ajouter!");
                    NomArt.Text = "";
                    NomCat.Text = "";
                    Quantite.Text = "";
                    Seuil.Text = "";
                }
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnRetour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Articles BacktoArticles = new Articles();
            BacktoArticles.Show();
            this.Hide();
        }
    }
}
