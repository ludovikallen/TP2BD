using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OracleConn;

namespace OracleConnection
{
    public partial class AjouterForm : Form
    {
        public AjouterForm()
        {
            InitializeComponent();
        }
        public AjouterForm(Oracle.ManagedDataAccess.Client.OracleConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        public Oracle.ManagedDataAccess.Client.OracleConnection conn;

        private void Ajouter_Load(object sender, EventArgs e)
        {
            remplirCategorie();
            BT_Ajouter.Enabled = false;
        }
        void remplirCategorie()
        {
            CB_Recherche.Items.Clear();
            string selectCategorie = "select * from categorieDisque";
            try
            {
                OracleCommand listeDiv = new OracleCommand(selectCategorie, conn);
                listeDiv.CommandType = CommandType.Text;
                OracleDataReader divisionReader = listeDiv.ExecuteReader();
                while (divisionReader.Read())
                {
                    CB_Recherche.Items.Add(divisionReader.GetString(1));
                }

                CB_Recherche.SelectedIndex = 0;
                divisionReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void verifierComplet()
        {
            if (TB_Nom.Text.Trim() != "" && CB_Recherche.SelectedIndex >= 0 && TB_Chanteur.Text.Trim() != "")
            {
                BT_Ajouter.Enabled = true;
            }
            else
            {
                BT_Ajouter.Enabled = false;
            }
        }
        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string codeCategorieCommand = "select codecategorie from CATEGORIEDISQUE where nomcategorie = '" + CB_Recherche.Text+"'";
                string codeCategorie = "";
                OracleCommand listeDiv = new OracleCommand(codeCategorieCommand, conn);
                listeDiv.CommandType = CommandType.Text;
                OracleDataReader divisionReader = listeDiv.ExecuteReader();
                while (divisionReader.Read())
                {
                    codeCategorie = divisionReader.GetString(0);
                }

                string SQL = "insert into disques values(40, '"+TB_Nom.Text.Trim() + "', '" + TB_Chanteur.Text.Trim()+"', " + numericUpDown1.Value+", '" +codeCategorie+"')";
                string SQL2 = SQL;

                OracleCommand oraAjoutDiv = new OracleCommand(SQL2, conn);

                int n = oraAjoutDiv.ExecuteNonQuery();
                MessageBox.Show(n + " ligne ajoutées");
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void TB_Nom_TextChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void CB_Recherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

    }
}
