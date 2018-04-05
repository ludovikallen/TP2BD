namespace OracleConnection
{
    partial class Modifier
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(78, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(118, 80);
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
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 21;
            // 
            // LB_Categorie
            // 
            this.LB_Categorie.AutoSize = true;
            this.LB_Categorie.Location = new System.Drawing.Point(17, 106);
            this.LB_Categorie.Name = "LB_Categorie";
            this.LB_Categorie.Size = new System.Drawing.Size(55, 13);
            this.LB_Categorie.TabIndex = 20;
            this.LB_Categorie.Text = "Catégorie:";
            // 
            // LB_Annee
            // 
            this.LB_Annee.AutoSize = true;
            this.LB_Annee.Location = new System.Drawing.Point(17, 83);
            this.LB_Annee.Name = "LB_Annee";
            this.LB_Annee.Size = new System.Drawing.Size(95, 13);
            this.LB_Annee.TabIndex = 19;
            this.LB_Annee.Text = "Année de la sortie:";
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(17, 60);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(32, 13);
            this.LB_Nom.TabIndex = 18;
            this.LB_Nom.Text = "Nom:";
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Ajouter.Location = new System.Drawing.Point(17, 130);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BT_Ajouter.TabIndex = 17;
            this.BT_Ajouter.Text = "Modifier";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            // 
            // LB_Ajouter
            // 
            this.LB_Ajouter.AutoSize = true;
            this.LB_Ajouter.Location = new System.Drawing.Point(14, 9);
            this.LB_Ajouter.Name = "LB_Ajouter";
            this.LB_Ajouter.Size = new System.Drawing.Size(96, 13);
            this.LB_Ajouter.TabIndex = 16;
            this.LB_Ajouter.Text = "Modifier un disque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id:";
            // 
            // LB_Id
            // 
            this.LB_Id.AutoSize = true;
            this.LB_Id.Location = new System.Drawing.Point(58, 37);
            this.LB_Id.Name = "LB_Id";
            this.LB_Id.Size = new System.Drawing.Size(35, 13);
            this.LB_Id.TabIndex = 25;
            this.LB_Id.Text = "label2";
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 162);
            this.Controls.Add(this.LB_Id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LB_Categorie);
            this.Controls.Add(this.LB_Annee);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.LB_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Modifier_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Id;
    }
}