namespace OracleConnection
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LB_Categorie = new System.Windows.Forms.Label();
            this.LB_Annee = new System.Windows.Forms.Label();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.LB_Ajouter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 52);
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
            this.numericUpDown1.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 13;
            // 
            // LB_Categorie
            // 
            this.LB_Categorie.AutoSize = true;
            this.LB_Categorie.Location = new System.Drawing.Point(12, 78);
            this.LB_Categorie.Name = "LB_Categorie";
            this.LB_Categorie.Size = new System.Drawing.Size(55, 13);
            this.LB_Categorie.TabIndex = 12;
            this.LB_Categorie.Text = "Catégorie:";
            // 
            // LB_Annee
            // 
            this.LB_Annee.AutoSize = true;
            this.LB_Annee.Location = new System.Drawing.Point(12, 55);
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
            this.LB_Nom.Size = new System.Drawing.Size(32, 13);
            this.LB_Nom.TabIndex = 10;
            this.LB_Nom.Text = "Nom:";
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.Location = new System.Drawing.Point(15, 102);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajouter.TabIndex = 9;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
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
            // Ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 310);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_Categorie);
            this.Controls.Add(this.LB_Annee);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.LB_Ajouter);
            this.Name = "Ajouter";
            this.Text = "Ajouter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LB_Categorie;
        private System.Windows.Forms.Label LB_Annee;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Label LB_Ajouter;
    }
}