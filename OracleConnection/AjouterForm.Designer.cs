namespace OracleConnection
{
    partial class AjouterForm
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
            this.CB_Recherche = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.LB_Categorie = new System.Windows.Forms.Label();
            this.LB_Annee = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.LB_Ajouter = new System.Windows.Forms.Label();
            this.TB_Chanteur = new System.Windows.Forms.TextBox();
            this.LB_Chanteur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Recherche
            // 
            this.CB_Recherche.FormattingEnabled = true;
            this.CB_Recherche.Location = new System.Drawing.Point(73, 93);
            this.CB_Recherche.Name = "CB_Recherche";
            this.CB_Recherche.Size = new System.Drawing.Size(144, 21);
            this.CB_Recherche.TabIndex = 15;
            this.CB_Recherche.SelectedIndexChanged += new System.EventHandler(this.CB_Recherche_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 71);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(99, 29);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(118, 20);
            this.TB_Nom.TabIndex = 13;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TB_Nom_TextChanged);
            // 
            // LB_Categorie
            // 
            this.LB_Categorie.AutoSize = true;
            this.LB_Categorie.Location = new System.Drawing.Point(12, 96);
            this.LB_Categorie.Name = "LB_Categorie";
            this.LB_Categorie.Size = new System.Drawing.Size(55, 13);
            this.LB_Categorie.TabIndex = 12;
            this.LB_Categorie.Text = "Catégorie:";
            // 
            // LB_Annee
            // 
            this.LB_Annee.AutoSize = true;
            this.LB_Annee.Location = new System.Drawing.Point(12, 73);
            this.LB_Annee.Name = "LB_Annee";
            this.LB_Annee.Size = new System.Drawing.Size(95, 13);
            this.LB_Annee.TabIndex = 11;
            this.LB_Annee.Text = "Année de la sortie:";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(12, 32);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(81, 13);
            this.LB_Nom.TabIndex = 10;
            this.LB_Nom.Text = "Nom du disque:";
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Ajouter.Location = new System.Drawing.Point(12, 120);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajouter.TabIndex = 9;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            this.BT_Ajouter.Click += new System.EventHandler(this.BT_Ajouter_Click);
            // 
            // LB_Ajouter
            // 
            this.LB_Ajouter.AutoSize = true;
            this.LB_Ajouter.Location = new System.Drawing.Point(12, 9);
            this.LB_Ajouter.Name = "LB_Ajouter";
            this.LB_Ajouter.Size = new System.Drawing.Size(92, 13);
            this.LB_Ajouter.TabIndex = 8;
            this.LB_Ajouter.Text = "Ajouter un disque:";
            // 
            // TB_Chanteur
            // 
            this.TB_Chanteur.Location = new System.Drawing.Point(71, 50);
            this.TB_Chanteur.Name = "TB_Chanteur";
            this.TB_Chanteur.Size = new System.Drawing.Size(146, 20);
            this.TB_Chanteur.TabIndex = 17;
            this.TB_Chanteur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LB_Chanteur
            // 
            this.LB_Chanteur.AutoSize = true;
            this.LB_Chanteur.Location = new System.Drawing.Point(12, 53);
            this.LB_Chanteur.Name = "LB_Chanteur";
            this.LB_Chanteur.Size = new System.Drawing.Size(53, 13);
            this.LB_Chanteur.TabIndex = 16;
            this.LB_Chanteur.Text = "Chanteur:";
            // 
            // AjouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 149);
            this.Controls.Add(this.TB_Chanteur);
            this.Controls.Add(this.LB_Chanteur);
            this.Controls.Add(this.CB_Recherche);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.LB_Categorie);
            this.Controls.Add(this.LB_Annee);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.LB_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjouterForm";
            this.Text = "Ajouter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterForm_FormClosing);
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.TextChanged += new System.EventHandler(this.AjouterForm_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Recherche;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label LB_Categorie;
        private System.Windows.Forms.Label LB_Annee;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Label LB_Ajouter;
        private System.Windows.Forms.TextBox TB_Chanteur;
        private System.Windows.Forms.Label LB_Chanteur;
    }
}