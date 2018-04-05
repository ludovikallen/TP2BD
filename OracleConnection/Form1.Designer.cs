namespace OracleConn
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Recherche = new System.Windows.Forms.TextBox();
            this.CB_Recherche = new System.Windows.Forms.ComboBox();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.BT_Modifier = new System.Windows.Forms.Button();
            this.LB_Recherche = new System.Windows.Forms.Label();
            this.LB_RechercheCategorie = new System.Windows.Forms.Label();
            this.LB_RechercheMots = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_Disque = new System.Windows.Forms.DataGridView();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Chanteur = new System.Windows.Forms.TextBox();
            this.TB_Annee = new System.Windows.Forms.TextBox();
            this.TB_Categorie = new System.Windows.Forms.TextBox();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.LB_Chanteur = new System.Windows.Forms.Label();
            this.LB_Annee = new System.Windows.Forms.Label();
            this.LB_Categorie = new System.Windows.Forms.Label();
            this.BT_Precedent = new System.Windows.Forms.Button();
            this.BT_Suivant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Disque)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Recherche
            // 
            this.TB_Recherche.Location = new System.Drawing.Point(577, 25);
            this.TB_Recherche.Name = "TB_Recherche";
            this.TB_Recherche.Size = new System.Drawing.Size(100, 20);
            this.TB_Recherche.TabIndex = 9;
            this.TB_Recherche.TextChanged += new System.EventHandler(this.TB_Recherche_TextChanged);
            // 
            // CB_Recherche
            // 
            this.CB_Recherche.FormattingEnabled = true;
            this.CB_Recherche.Location = new System.Drawing.Point(450, 24);
            this.CB_Recherche.Name = "CB_Recherche";
            this.CB_Recherche.Size = new System.Drawing.Size(121, 21);
            this.CB_Recherche.TabIndex = 10;
            this.CB_Recherche.SelectedIndexChanged += new System.EventHandler(this.CB_Recherche_SelectedIndexChanged);
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.Location = new System.Drawing.Point(13, 21);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajouter.TabIndex = 11;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            this.BT_Ajouter.Click += new System.EventHandler(this.BT_Ajouter_Click);
            // 
            // BT_Modifier
            // 
            this.BT_Modifier.Location = new System.Drawing.Point(94, 21);
            this.BT_Modifier.Name = "BT_Modifier";
            this.BT_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BT_Modifier.TabIndex = 12;
            this.BT_Modifier.Text = "Modifier";
            this.BT_Modifier.UseVisualStyleBackColor = true;
            this.BT_Modifier.Click += new System.EventHandler(this.BT_Modifier_Click);
            // 
            // LB_Recherche
            // 
            this.LB_Recherche.AutoSize = true;
            this.LB_Recherche.Location = new System.Drawing.Point(381, 28);
            this.LB_Recherche.Name = "LB_Recherche";
            this.LB_Recherche.Size = new System.Drawing.Size(63, 13);
            this.LB_Recherche.TabIndex = 13;
            this.LB_Recherche.Text = "Recherche:";
            // 
            // LB_RechercheCategorie
            // 
            this.LB_RechercheCategorie.AutoSize = true;
            this.LB_RechercheCategorie.Location = new System.Drawing.Point(447, 9);
            this.LB_RechercheCategorie.Name = "LB_RechercheCategorie";
            this.LB_RechercheCategorie.Size = new System.Drawing.Size(52, 13);
            this.LB_RechercheCategorie.TabIndex = 14;
            this.LB_RechercheCategorie.Text = "Catégorie";
            // 
            // LB_RechercheMots
            // 
            this.LB_RechercheMots.AutoSize = true;
            this.LB_RechercheMots.Location = new System.Drawing.Point(574, 9);
            this.LB_RechercheMots.Name = "LB_RechercheMots";
            this.LB_RechercheMots.Size = new System.Drawing.Size(28, 13);
            this.LB_RechercheMots.TabIndex = 15;
            this.LB_RechercheMots.Text = "Titre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DGV_Disque
            // 
            this.DGV_Disque.AllowUserToAddRows = false;
            this.DGV_Disque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Disque.Location = new System.Drawing.Point(13, 51);
            this.DGV_Disque.Name = "DGV_Disque";
            this.DGV_Disque.ReadOnly = true;
            this.DGV_Disque.Size = new System.Drawing.Size(664, 156);
            this.DGV_Disque.TabIndex = 18;
            this.DGV_Disque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Disque_CellDoubleClick_1);
            this.DGV_Disque.SelectionChanged += new System.EventHandler(this.DGV_Disque_SelectionChanged_1);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(13, 227);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(100, 20);
            this.TB_Nom.TabIndex = 19;
            // 
            // TB_Chanteur
            // 
            this.TB_Chanteur.Location = new System.Drawing.Point(119, 227);
            this.TB_Chanteur.Name = "TB_Chanteur";
            this.TB_Chanteur.ReadOnly = true;
            this.TB_Chanteur.Size = new System.Drawing.Size(100, 20);
            this.TB_Chanteur.TabIndex = 20;
            // 
            // TB_Annee
            // 
            this.TB_Annee.Location = new System.Drawing.Point(225, 227);
            this.TB_Annee.Name = "TB_Annee";
            this.TB_Annee.ReadOnly = true;
            this.TB_Annee.Size = new System.Drawing.Size(100, 20);
            this.TB_Annee.TabIndex = 21;
            // 
            // TB_Categorie
            // 
            this.TB_Categorie.Location = new System.Drawing.Point(331, 227);
            this.TB_Categorie.Name = "TB_Categorie";
            this.TB_Categorie.ReadOnly = true;
            this.TB_Categorie.Size = new System.Drawing.Size(100, 20);
            this.TB_Categorie.TabIndex = 22;
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(13, 212);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(79, 13);
            this.LB_Nom.TabIndex = 23;
            this.LB_Nom.Text = "Nom de l\'album";
            // 
            // LB_Chanteur
            // 
            this.LB_Chanteur.AutoSize = true;
            this.LB_Chanteur.Location = new System.Drawing.Point(119, 212);
            this.LB_Chanteur.Name = "LB_Chanteur";
            this.LB_Chanteur.Size = new System.Drawing.Size(50, 13);
            this.LB_Chanteur.TabIndex = 24;
            this.LB_Chanteur.Text = "Chanteur";
            // 
            // LB_Annee
            // 
            this.LB_Annee.AutoSize = true;
            this.LB_Annee.Location = new System.Drawing.Point(225, 212);
            this.LB_Annee.Name = "LB_Annee";
            this.LB_Annee.Size = new System.Drawing.Size(92, 13);
            this.LB_Annee.TabIndex = 25;
            this.LB_Annee.Text = "Année de la sortie";
            // 
            // LB_Categorie
            // 
            this.LB_Categorie.AutoSize = true;
            this.LB_Categorie.Location = new System.Drawing.Point(331, 212);
            this.LB_Categorie.Name = "LB_Categorie";
            this.LB_Categorie.Size = new System.Drawing.Size(52, 13);
            this.LB_Categorie.TabIndex = 26;
            this.LB_Categorie.Text = "Catégorie";
            // 
            // BT_Precedent
            // 
            this.BT_Precedent.Location = new System.Drawing.Point(437, 225);
            this.BT_Precedent.Name = "BT_Precedent";
            this.BT_Precedent.Size = new System.Drawing.Size(75, 23);
            this.BT_Precedent.TabIndex = 27;
            this.BT_Precedent.Text = "Précédent";
            this.BT_Precedent.UseVisualStyleBackColor = true;
            this.BT_Precedent.Click += new System.EventHandler(this.BT_Precedent_Click);
            // 
            // BT_Suivant
            // 
            this.BT_Suivant.Location = new System.Drawing.Point(518, 224);
            this.BT_Suivant.Name = "BT_Suivant";
            this.BT_Suivant.Size = new System.Drawing.Size(75, 23);
            this.BT_Suivant.TabIndex = 28;
            this.BT_Suivant.Text = "Suivant";
            this.BT_Suivant.UseVisualStyleBackColor = true;
            this.BT_Suivant.Click += new System.EventHandler(this.BT_Suivant_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 259);
            this.Controls.Add(this.BT_Suivant);
            this.Controls.Add(this.BT_Precedent);
            this.Controls.Add(this.LB_Categorie);
            this.Controls.Add(this.LB_Annee);
            this.Controls.Add(this.LB_Chanteur);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.TB_Categorie);
            this.Controls.Add(this.TB_Annee);
            this.Controls.Add(this.TB_Chanteur);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.DGV_Disque);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LB_RechercheMots);
            this.Controls.Add(this.LB_RechercheCategorie);
            this.Controls.Add(this.LB_Recherche);
            this.Controls.Add(this.BT_Modifier);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.CB_Recherche);
            this.Controls.Add(this.TB_Recherche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Disque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TB_Recherche;
        private System.Windows.Forms.ComboBox CB_Recherche;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Button BT_Modifier;
        private System.Windows.Forms.Label LB_Recherche;
        private System.Windows.Forms.Label LB_RechercheCategorie;
        private System.Windows.Forms.Label LB_RechercheMots;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_Disque;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Chanteur;
        private System.Windows.Forms.TextBox TB_Annee;
        private System.Windows.Forms.TextBox TB_Categorie;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Label LB_Chanteur;
        private System.Windows.Forms.Label LB_Annee;
        private System.Windows.Forms.Label LB_Categorie;
        private System.Windows.Forms.Button BT_Precedent;
        private System.Windows.Forms.Button BT_Suivant;
    }
}

