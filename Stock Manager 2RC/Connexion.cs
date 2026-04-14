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
    public partial class Connexion : Form
    {
        Fonctions Con;
        public Connexion()
        {
            InitializeComponent();
            Con = new Fonctions();
        }
        public static int IdUser;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Veuillez entrer le mot de passe de l'administrateur pour vous connecter!");
            }
            else 
            {
                string MotdePasse = txtPassword.Text;
                string Req = "select * from TblAdmin where Password = '{0}'";
                Req = string.Format(Req, MotdePasse);
                DataTable dt = Con.RecupererDonnees(Req);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Mot de Passe Incorrect!");
                }
                else 
                {
                    Articles GotoArticles = new Articles();
                    GotoArticles.Show();
                    this.Hide();
                }
                txtPassword.Text = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblLoginAdmin_Click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConnexionSAdmin GotoSAdmin = new ConnexionSAdmin();
            GotoSAdmin.Show();
            this.Hide();
        }

        private void btnExit_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
