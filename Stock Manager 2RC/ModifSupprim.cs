using System;
using System.Windows.Forms;

namespace Stock_Manager_2RC
{
    public partial class ModifSupprim : Form
    {
        Fonctions Con;
        public ModifSupprim()
        {
            InitializeComponent();
            Con = new Fonctions();
            ListerArticles();
        }
        private void ListerArticles()
        {
            string Req = "Select * from TblArticles";
            ListeArt.DataSource = Con.RecupererDonnees(Req);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ModifSupprim_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomArt.Text == "" || NomCat.Text == "" || Quantite.Text == "" || Seuil.Text == "")
                {
                    MessageBox.Show("Veuillez vous rassurer d'avoir selectionner un materiel!");
                }
                else
                {
                    string Nom = NomArt.Text;
                    string Cat = NomCat.Text;
                    int Qnt = Convert.ToInt32(Quantite.Text);
                    int Sl = Convert.ToInt32(Seuil.Text);
                    DateTime Date = ModifDate.Value.Date;
                    string Etat = "Article Modifié!";
                    string Req2 = "insert into TblHistorique values('{0}','{1}','{2}','{3}')";
                    Req2 = string.Format(Req2, Nom, Qnt, @Date, Etat);
                    Con.EnvoyerDonnees(Req2);
                    string Req1 = "Update TblArticles set NomArt = '{0}', CatArt = '{1}', StockArt = '{2}', SeuilArt = '{3}' where IdArt = {4}";
                    Req1 = string.Format(Req1, Nom, Cat, Qnt, Sl, Key);                   
                    Con.EnvoyerDonnees(Req1);                   
                    ListerArticles();
                    MessageBox.Show("Le Materiel a bien été Modifier!");
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

        int Key = 0;
        private void ListeArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

             if (e.RowIndex >= 0 && ListeArt.Rows.Count > e.RowIndex)
             {
                DataGridViewRow row = ListeArt.Rows[e.RowIndex];

                // Vérifie qu’il y a assez de colonnes
                if (row.Cells.Count >= 5)
                {
                    NomArt.Text = row.Cells[1].Value.ToString() ?? "";
                    NomCat.Text = row.Cells[2].Value.ToString() ?? "";
                    Quantite.Text = row.Cells[3].Value.ToString() ?? "";
                    Seuil.Text = row.Cells[4].Value.ToString() ?? "";

                    if (string.IsNullOrEmpty(NomArt.Text) || string.IsNullOrEmpty(NomCat.Text))
                    {
                        Key = 0;
                    }
                    else
                    {
                        Key = Convert.ToInt32(row.Cells[0].Value);
                    }
                 }
             }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomArt.Text == "" || NomCat.Text == "" || Quantite.Text == "" || Seuil.Text == "")
                {
                    MessageBox.Show("Veuillez vous rassurer qu'un materiel à bien été selectionner!");
                }
                else
                {
                    string Nom = NomArt.Text;
                    string Cat = NomCat.Text;
                    int Qnt = Convert.ToInt32(Quantite.Text);
                    int Sl = Convert.ToInt32(Seuil.Text);
                    DateTime Date = ModifDate.Value.Date;
                    string Etat = "Article Supprimer!";
                    string Req2 = "insert into TblHistorique values('{0}','{1}','{2}','{3}')";
                    Req2 = string.Format(Req2, Nom, Qnt, Date, Etat);
                    Con.EnvoyerDonnees(Req2);
                    string Req1 = "delete from TblArticles where IdArt = '{0}'";
                    Req1 = string.Format(Req1, Key);
                    Con.EnvoyerDonnees(Req1);
                    ListerArticles();
                    MessageBox.Show("Le Materiel a bien été Supprimer!");
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
