using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace OracleConnection
{
    public partial class Modifier : Form
    {
        public Modifier()
        {
            InitializeComponent();
        }
        public Modifier(Oracle.ManagedDataAccess.Client.OracleConnection connection, int num)
        {
            InitializeComponent();
            conn = connection;
            numId = num;
        }

        public Oracle.ManagedDataAccess.Client.OracleConnection conn;
        private int numId;

        private void Modifier_Load(object sender, EventArgs e)
        {
            remplirCategorie();
            remplirDonnees();
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string codeCategorieCommand = "select codecategorie from CATEGORIEDISQUE where nomcategorie = '" + comboBox1.Text + "'";
                string codeCategorie = "";
                OracleCommand listeDiv = new OracleCommand(codeCategorieCommand, conn);
                listeDiv.CommandType = CommandType.Text;
                OracleDataReader divisionReader = listeDiv.ExecuteReader();
                while (divisionReader.Read())
                {
                    codeCategorie = divisionReader.GetString(0);
                }


                string sql = "UPDATE disques SET titredisque = '" + textBox1.Text + "', nomartiste = '" + TB_Chanteur.Text + "', anneedisque = " + numericUpDown1.Value + ", codecategorie = '"+ codeCategorie+ "' WHERE nodisques = " + LB_Id.Text;
                OracleCommand oraAjoutDiv = new OracleCommand(sql, conn);
                int n = oraAjoutDiv.ExecuteNonQuery();
                MessageBox.Show(n + " ligne modifiée");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        void remplirCategorie()
        {
            comboBox1.Items.Clear();
            string selectCategorie = "select * from categorieDisque";
            try
            {
                OracleCommand listeDiv = new OracleCommand(selectCategorie, conn);
                listeDiv.CommandType = CommandType.Text;
                OracleDataReader divisionReader = listeDiv.ExecuteReader();
                while (divisionReader.Read())
                {
                    comboBox1.Items.Add(divisionReader.GetString(1));
                }

                comboBox1.SelectedIndex = 0;
                divisionReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void remplirDonnees()
        {
            LB_Id.Text = numId.ToString();
            string sql = "select titredisque, nomartiste, anneedisque, NOMCATEGORIE from disques inner join categoriedisque on categoriedisque.CODECATEGORIE = disques.CODECATEGORIE where nodisques = " + LB_Id.Text;
            OracleCommand listeEquipe = new OracleCommand(sql, conn);

            listeEquipe.CommandType = CommandType.Text;
            OracleDataReader equipeReader = listeEquipe.ExecuteReader();
            while (equipeReader.Read())
            {
                textBox1.Text = equipeReader.GetString(0);
                TB_Chanteur.Text = equipeReader.GetString(1);
                numericUpDown1.Value = equipeReader.GetDecimal(2);
            }
            equipeReader.Close();
        }

        void verifierComplet()
        {
            if (TB_Chanteur.Text.Trim() != "" && comboBox1.SelectedIndex >= 0 && textBox1.Text.Trim() != "")
            {
                BT_Ajouter.Enabled = true;
            }
            else
            {
                BT_Ajouter.Enabled = false;
            }
        }

        private void TB_Chanteur_TextChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            verifierComplet();
        }
    }
}