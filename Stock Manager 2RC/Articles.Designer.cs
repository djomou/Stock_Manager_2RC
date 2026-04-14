namespace Stock_Manager_2RC
{
    partial class Articles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articles));
            this.Modifier = new System.Windows.Forms.Button();
            this.ListeArt = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Historique = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Deconnexion = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Telecharger = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListeArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.SteelBlue;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(65, 283);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(203, 39);
            this.Modifier.TabIndex = 171;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // ListeArt
            // 
            this.ListeArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListeArt.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ListeArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListeArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeArt.EnableHeadersVisualStyles = false;
            this.ListeArt.GridColor = System.Drawing.Color.SteelBlue;
            this.ListeArt.Location = new System.Drawing.Point(330, 73);
            this.ListeArt.Name = "ListeArt";
            this.ListeArt.ReadOnly = true;
            this.ListeArt.Size = new System.Drawing.Size(701, 359);
            this.ListeArt.TabIndex = 169;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 168;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 37);
            this.panel1.TabIndex = 161;
            // 
            // Supprimer
            // 
            this.Supprimer.BackColor = System.Drawing.Color.DarkRed;
            this.Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supprimer.ForeColor = System.Drawing.Color.White;
            this.Supprimer.Location = new System.Drawing.Point(65, 339);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(203, 39);
            this.Supprimer.TabIndex = 160;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = false;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Historique
            // 
            this.Historique.BackColor = System.Drawing.Color.Chocolate;
            this.Historique.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historique.ForeColor = System.Drawing.Color.White;
            this.Historique.Location = new System.Drawing.Point(65, 393);
            this.Historique.Name = "Historique";
            this.Historique.Size = new System.Drawing.Size(203, 39);
            this.Historique.TabIndex = 178;
            this.Historique.Text = "Historique";
            this.Historique.UseVisualStyleBackColor = false;
            this.Historique.Click += new System.EventHandler(this.Historique_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.SeaGreen;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ForeColor = System.Drawing.Color.White;
            this.Ajouter.Location = new System.Drawing.Point(65, 227);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(203, 39);
            this.Ajouter.TabIndex = 180;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Deconnexion
            // 
            this.Deconnexion.Image = ((System.Drawing.Image)(resources.GetObject("Deconnexion.Image")));
            this.Deconnexion.Location = new System.Drawing.Point(992, 11);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(56, 40);
            this.Deconnexion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Deconnexion.TabIndex = 181;
            this.Deconnexion.TabStop = false;
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 179;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 48);
            this.label2.TabIndex = 185;
            this.label2.Text = "2RC Stock Manager\r\n\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-8, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1453, 66);
            this.flowLayoutPanel1.TabIndex = 184;
            // 
            // Telecharger
            // 
            this.Telecharger.BackColor = System.Drawing.Color.SteelBlue;
            this.Telecharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telecharger.ForeColor = System.Drawing.Color.White;
            this.Telecharger.Location = new System.Drawing.Point(594, 445);
            this.Telecharger.Name = "Telecharger";
            this.Telecharger.Size = new System.Drawing.Size(203, 39);
            this.Telecharger.TabIndex = 188;
            this.Telecharger.Text = "Télécharger";
            this.Telecharger.UseVisualStyleBackColor = false;
            this.Telecharger.Click += new System.EventHandler(this.Telecharger_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 532);
            this.Controls.Add(this.Telecharger);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Deconnexion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Historique);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.ListeArt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Supprimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2RC Stock Manager";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListeArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deconnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.DataGridView ListeArt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Historique;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.PictureBox Deconnexion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Telecharger;
    }
}