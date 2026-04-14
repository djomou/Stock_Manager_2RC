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
    public partial class ConnexionSAdmin : Form
    {
        public ConnexionSAdmin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Entrer le mot de passe du Super-Administrateur!");
            }
            else 
            {
                if (txtPassword.Text == "Super_Admin-001@")
                {
                    SuperAdmin GotoSAdmin = new SuperAdmin();
                    GotoSAdmin.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Mot de passe Incorrect!");
                }
                txtPassword.Text = "";
            }
        }

        private void lblBackToLogin_Click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion BacktoConnexion = new Connexion();
            BacktoConnexion.Show();
            this.Hide();
        }
    }
}
