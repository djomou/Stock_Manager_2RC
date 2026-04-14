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
    public partial class SuperAdmin : Form
    {
        Fonctions Con;
        public SuperAdmin()
        {
            InitializeComponent();
            Con = new Fonctions();
        }

        private void lblBackToLogin_Click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConnexionSAdmin GotoSAdmin = new ConnexionSAdmin();
            GotoSAdmin.Show();
            this.Hide();
        }

        private void btnLogin_Click_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de pouvoir ajouter!");
            }
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    string MotdePasse = txtPassword.Text;
                    string Req = "insert into TblAdmin values('{0}')";
                    Req = string.Format(Req, MotdePasse);
                    Con.EnvoyerDonnees(Req);
                    MessageBox.Show("Le Mot de passe a bien été ajouter!");
                    txtPassword.Text = "";
                    
                }
                else
                {
                    MessageBox.Show("Password et Confirm_Password doivent être identique!");
                }
                txtPassword.Text = "";
                txtConfirm.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
