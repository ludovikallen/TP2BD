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
            this.DGV_Disque = new System.Windows.Forms.DataGridView();
            this.numSequentiel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDisque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_Recherche = new System.Windows.Forms.TextBox();
            this.CB_Recherche = new System.Windows.Forms.ComboBox();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.BT_Modifier = new System.Windows.Forms.Button();
            this.LB_Recherche = new System.Windows.Forms.Label();
            this.LB_RechercheCategorie = new System.Windows.Forms.Label();
            this.LB_RechercheMots = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Disque)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Disque
            // 
            this.DGV_Disque.AllowUserToAddRows = false;
            this.DGV_Disque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Disque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSequentiel,
            this.nomDisque,
            this.annee,
            this.categorie});
            this.DGV_Disque.Location = new System.Drawing.Point(12, 51);
            this.DGV_Disque.Name = "DGV_Disque";
            this.DGV_Disque.Size = new System.Drawing.Size(551, 150);
            this.DGV_Disque.TabIndex = 8;
            this.DGV_Disque.DoubleClick += new System.EventHandler(this.DGV_Disque_DoubleClick);
            // 
            // numSequentiel
            // 
            this.numSequentiel.HeaderText = "Numéro Séquenciel";
            this.numSequentiel.Name = "numSequentiel";
            this.numSequentiel.Width = 125;
            // 
            // nomDisque
            // 
            this.nomDisque.HeaderText = "Nom du disque";
            this.nomDisque.Name = "nomDisque";
            this.nomDisque.Width = 125;
            // 
            // annee
            // 
            this.annee.HeaderText = "Année de la sortie";
            this.annee.Name = "annee";
            this.annee.Width = 125;
            // 
            // categorie
            // 
            this.categorie.HeaderText = "Catégorie";
            this.categorie.Name = "categorie";
            this.categorie.Width = 125;
            // 
            // TB_Recherche
            // 
            this.TB_Recherche.Location = new System.Drawing.Point(463, 25);
            this.TB_Recherche.Name = "TB_Recherche";
            this.TB_Recherche.Size = new System.Drawing.Size(100, 20);
            this.TB_Recherche.TabIndex = 9;
            // 
            // CB_Recherche
            // 
            this.CB_Recherche.FormattingEnabled = true;
            this.CB_Recherche.Location = new System.Drawing.Point(336, 24);
            this.CB_Recherche.Name = "CB_Recherche";
            this.CB_Recherche.Size = new System.Drawing.Size(121, 21);
            this.CB_Recherche.TabIndex = 10;
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.Location = new System.Drawing.Point(13, 21);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajouter.TabIndex = 11;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            // 
            // BT_Modifier
            // 
            this.BT_Modifier.Location = new System.Drawing.Point(94, 21);
            this.BT_Modifier.Name = "BT_Modifier";
            this.BT_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BT_Modifier.TabIndex = 12;
            this.BT_Modifier.Text = "Modifier";
            this.BT_Modifier.UseVisualStyleBackColor = true;
            // 
            // LB_Recherche
            // 
            this.LB_Recherche.AutoSize = true;
            this.LB_Recherche.Location = new System.Drawing.Point(267, 28);
            this.LB_Recherche.Name = "LB_Recherche";
            this.LB_Recherche.Size = new System.Drawing.Size(63, 13);
            this.LB_Recherche.TabIndex = 13;
            this.LB_Recherche.Text = "Recherche:";
            // 
            // LB_RechercheCategorie
            // 
            this.LB_RechercheCategorie.AutoSize = true;
            this.LB_RechercheCategorie.Location = new System.Drawing.Point(333, 9);
            this.LB_RechercheCategorie.Name = "LB_RechercheCategorie";
            this.LB_RechercheCategorie.Size = new System.Drawing.Size(52, 13);
            this.LB_RechercheCategorie.TabIndex = 14;
            this.LB_RechercheCategorie.Text = "Catégorie";
            // 
            // LB_RechercheMots
            // 
            this.LB_RechercheMots.AutoSize = true;
            this.LB_RechercheMots.Location = new System.Drawing.Point(460, 9);
            this.LB_RechercheMots.Name = "LB_RechercheMots";
            this.LB_RechercheMots.Size = new System.Drawing.Size(28, 13);
            this.LB_RechercheMots.TabIndex = 15;
            this.LB_RechercheMots.Text = "Titre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 219);
            this.Controls.Add(this.LB_RechercheMots);
            this.Controls.Add(this.LB_RechercheCategorie);
            this.Controls.Add(this.LB_Recherche);
            this.Controls.Add(this.BT_Modifier);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.CB_Recherche);
            this.Controls.Add(this.TB_Recherche);
            this.Controls.Add(this.DGV_Disque);
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
        private System.Windows.Forms.DataGridView DGV_Disque;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSequentiel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDisque;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorie;
        private System.Windows.Forms.TextBox TB_Recherche;
        private System.Windows.Forms.ComboBox CB_Recherche;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Button BT_Modifier;
        private System.Windows.Forms.Label LB_Recherche;
        private System.Windows.Forms.Label LB_RechercheCategorie;
        private System.Windows.Forms.Label LB_RechercheMots;
    }
}

