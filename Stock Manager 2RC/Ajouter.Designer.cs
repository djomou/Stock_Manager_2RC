namespace Stock_Manager_2RC
{
    partial class Ajouter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRetour = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ajoute = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Seuil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Quantite = new System.Windows.Forms.TextBox();
            this.NomCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NomArt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModifDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.BtnRetour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 42);
            this.panel1.TabIndex = 33;
            // 
            // BtnRetour
            // 
            this.BtnRetour.AutoSize = true;
            this.BtnRetour.BackColor = System.Drawing.Color.White;
            this.BtnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.LinkColor = System.Drawing.Color.SteelBlue;
            this.BtnRetour.Location = new System.Drawing.Point(154, 13);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(64, 20);
            this.BtnRetour.TabIndex = 39;
            this.BtnRetour.TabStop = true;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnRetour_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Ajoute
            // 
            this.Ajoute.BackColor = System.Drawing.Color.SeaGreen;
            this.Ajoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajoute.ForeColor = System.Drawing.Color.White;
            this.Ajoute.Location = new System.Drawing.Point(84, 421);
            this.Ajoute.Name = "Ajoute";
            this.Ajoute.Size = new System.Drawing.Size(203, 39);
            this.Ajoute.TabIndex = 32;
            this.Ajoute.Text = "Ajouter";
            this.Ajoute.UseVisualStyleBackColor = false;
            this.Ajoute.Click += new System.EventHandler(this.Ajoute_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(11, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seuil :";
            // 
            // Seuil
            // 
            this.Seuil.BackColor = System.Drawing.SystemColors.Control;
            this.Seuil.Location = new System.Drawing.Point(137, 342);
            this.Seuil.Name = "Seuil";
            this.Seuil.Size = new System.Drawing.Size(201, 20);
            this.Seuil.TabIndex = 30;
            this.Seuil.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(11, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Quantité :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(368, 66);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // Quantite
            // 
            this.Quantite.BackColor = System.Drawing.SystemColors.Control;
            this.Quantite.Location = new System.Drawing.Point(137, 302);
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(201, 20);
            this.Quantite.TabIndex = 38;
            // 
            // NomCat
            // 
            this.NomCat.BackColor = System.Drawing.SystemColors.Control;
            this.NomCat.Location = new System.Drawing.Point(137, 261);
            this.NomCat.Name = "NomCat";
            this.NomCat.Size = new System.Drawing.Size(201, 20);
            this.NomCat.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(11, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Catégorie Art :";
            // 
            // NomArt
            // 
            this.NomArt.BackColor = System.Drawing.SystemColors.Control;
            this.NomArt.Location = new System.Drawing.Point(138, 217);
            this.NomArt.Name = "NomArt";
            this.NomArt.Size = new System.Drawing.Size(201, 20);
            this.NomArt.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nom Article :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 48);
            this.label1.TabIndex = 183;
            this.label1.Text = "2RC Stock Manager\r\n\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(12, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 184;
            this.label4.Text = "Date D\'ajout :";
            // 
            // ModifDate
            // 
            this.ModifDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModifDate.Location = new System.Drawing.Point(135, 380);
            this.ModifDate.Name = "ModifDate";
            this.ModifDate.Size = new System.Drawing.Size(203, 20);
            this.ModifDate.TabIndex = 185;
            // 
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(367, 515);
            this.Controls.Add(this.ModifDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NomArt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NomCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Quantite);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Ajoute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Seuil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Ajoute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Seuil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Quantite;
        private System.Windows.Forms.LinkLabel BtnRetour;
        private System.Windows.Forms.TextBox NomCat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NomArt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker ModifDate;
    }
}