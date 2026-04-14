using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Stock_Manager_2RC
{
    public partial class Articles : Form
    {
        Fonctions Con;
        public Articles()
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

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Ajouter GotoAjouter = new Ajouter();
            GotoAjouter.Show();
            this.Hide();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            ModifSupprim GotoModifSupprim = new ModifSupprim();
            GotoModifSupprim.Show();
            this.Hide();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            ModifSupprim GotoModifSupprim = new ModifSupprim();
            GotoModifSupprim.Show();
            this.Hide();
        }

        private void Historique_Click(object sender, EventArgs e)
        {
            Historique GotoHistorique = new Historique();
            GotoHistorique.Show();
            this.Hide();
        }

        private void Deconnexion_Click(object sender, EventArgs e)
        {
            Connexion BacktoConnexion = new Connexion();
            BacktoConnexion.Show();
            this.Hide();
        }

        private void DeleteLignes_Click(object sender, EventArgs e)
        {
            // Afficher une boîte de confirmation
            DialogResult result = MessageBox.Show(
                "Voulez-vous vraiment vider le tableau ?",   // Message
                "Confirmation",                              // Titre
                MessageBoxButtons.YesNo,                     // Boutons Oui / Non
                MessageBoxIcon.Question                      // Icône
            );

            if (result == DialogResult.Yes)
            {
                try
                {

                    string Req = "TRUNCATE TABLE TblArticles";
                    Req = string.Format(Req);
                    Con.EnvoyerDonnees(Req);
                    ListerArticles();

                    MessageBox.Show("La table a été vidée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si l’utilisateur clique sur NON → rien ne se passe
                MessageBox.Show("Opération annulée.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Telecharger_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Fichier PDF|*.pdf";
            saveFile.Title = "Enregistrer le document PDF";
            saveFile.FileName = "StockManager.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter.GetInstance(doc, new FileStream(saveFile.FileName, FileMode.Create));
                    doc.Open();

                    // Titre en gras et centré
                    iTextSharp.text.Font titreFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    Paragraph titre = new Paragraph("2RC StockManager", titreFont);
                    titre.Alignment = Element.ALIGN_CENTER;
                    doc.Add(titre);

                    doc.Add(new Paragraph("\n")); // espace

                    // Création du tableau avec numérotation
                    PdfPTable table = new PdfPTable(ListeArt.Columns.Count + 1);
                    table.WidthPercentage = 100;
                    table.SpacingBefore = 10f;
                    table.SpacingAfter = 10f;

                    // Couleur d’en-tête
                    BaseColor headerColor = new BaseColor(230, 230, 250); // lavande
                    iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.BLACK);

                    // Cellule d’en-tête : Numéro
                    PdfPCell cellNum = new PdfPCell(new Phrase("N°", headerFont));
                    cellNum.BackgroundColor = headerColor;
                    cellNum.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(cellNum);

                     // Cellules d’en-tête : colonnes du DataGridView
                    foreach (DataGridViewColumn col in ListeArt.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                        cell.BackgroundColor = headerColor;
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }

                    // Contenu des lignes
                    iTextSharp.text.Font rowFont = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.DARK_GRAY);
                    int compteur = 1;

                    foreach (DataGridViewRow row in ListeArt.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            // Numérotation
                            PdfPCell numCell = new PdfPCell(new Phrase(compteur.ToString(), rowFont));
                            numCell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(numCell);

                            // Données
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string text = cell.Value != null ? cell.Value.ToString() : "";
                                PdfPCell dataCell = new PdfPCell(new Phrase(text, rowFont));
                                dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                                table.AddCell(dataCell);
                            }

                            compteur++;
                        }
                    }

                    doc.Add(table);
                    doc.Close();

                    MessageBox.Show("Document PDF généré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }

        }

    }
}
