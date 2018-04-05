using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OracleConnection;

namespace OracleConn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Connecter();
            BT_Modifier.Enabled = false;

            remplirRechercheCategorie();
            remplirDisque();

            TB_Nom.DataBindings.Add("Text", dataSet, "listeDisque.titredisque");
            TB_Chanteur.DataBindings.Add("Text", dataSet, "listeDisque.nomartiste");
            TB_Annee.DataBindings.Add("Text", dataSet, "listeDisque.anneedisque");
            TB_Categorie.DataBindings.Add("Text", dataSet, "listeDisque.nomcategorie");
        }

        public Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection();
        public DataSet dataSet = new DataSet();


        private void Connecter()
        {
            try
            {
                string dSource =
                    "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 205.237.244.251)(PORT = 1521)) (CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
                string bd = "Data Source = " + dSource + "; User Id =" + "paymente" + "; Password = " + "ORACLE1";
                conn.ConnectionString = bd;
                conn.Open();
               // MessageBox.Show(conn.State.ToString());
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void Deconnecter()
        {
            try
            {
                conn.Close();
               // MessageBox.Show(conn.State.ToString());
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Deconnecter();
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            var popup = new AjouterForm(conn, dataSet, DGV_Disque);
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            modifierDisque();
        }

        void modifierDisque()
        {
            var popup = new Modifier(conn, Convert.ToInt32(DGV_Disque.CurrentRow.Cells[0].Value), dataSet, DGV_Disque);
            DialogResult dialogresult = popup.ShowDialog();
        }

        void remplirRechercheCategorie()
        {
            CB_Recherche.Items.Clear();
            CB_Recherche.Items.Add("Toutes les catégories");
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

        public void remplirDisque()
        {
            try
            {
                string sqlEquipe = "select nodisques,titredisque, nomartiste, anneedisque, nomcategorie from disques inner join CATEGORIEDISQUE on categoriedisque.codecategorie = disques.CODECATEGORIE order by nodisques";
                OracleDataAdapter adapter = new OracleDataAdapter(sqlEquipe, conn);

                if (dataSet.Tables.Contains("listeDisque"))
                {
                    dataSet.Tables["listeDisque"].Clear();
                }

                adapter.Fill(dataSet, "listeDisque");
                BindingSource source;
                source = new BindingSource(dataSet, "listeDisque");
                DGV_Disque.DataSource = source;
                adapter.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        
        private void CB_Recherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercheDisque();
            if (CB_Recherche.SelectedIndex > 0)
            {
                string STL =
                    "select count(disques.codecategorie), nomcategorie from disques inner join categoriedisque on categoriedisque.CODECATEGORIE = disques.codecategorie where nomcategorie = '" + CB_Recherche.Text + "' group by nomcategorie";
                OracleCommand listeDiv = new OracleCommand(STL, conn);
                listeDiv.CommandType = CommandType.Text;
                decimal number = 0;
                OracleDataReader divisionReader = listeDiv.ExecuteReader();
                while (divisionReader.Read())
                {
                    number = divisionReader.GetDecimal(0);
                }
                divisionReader.Close();
                if (number > 1)
                {
                    MessageBox.Show(number + " titres dans " + CB_Recherche.Text);
                }
                else
                {
                    MessageBox.Show(number + " titre dans " + CB_Recherche.Text);
                }

            }
        }

        void rechercheDisque()
        {
            try
            {
                if (CB_Recherche.SelectedIndex > 0)
                {
                    DGV_Disque.DataSource = null;
                    string sqlEquipe;
                    if (TB_Recherche.Text.Trim() == "")
                    {
                        sqlEquipe = "select nodisques,titredisque, nomartiste, anneedisque, nomcategorie from disques inner join CATEGORIEDISQUE on categoriedisque.codecategorie = disques.CODECATEGORIE where nomcategorie = '" + CB_Recherche.Text + "'";
                        OracleDataAdapter adapter = new OracleDataAdapter(sqlEquipe, conn);

                        if (dataSet.Tables.Contains("listeDisque"))
                        {
                            dataSet.Tables["listeDisque"].Clear();
                        }

                        adapter.Fill(dataSet, "listeDisque");
                        BindingSource source;
                        source = new BindingSource(dataSet, "listeDisque");
                        DGV_Disque.DataSource = source;
                        adapter.Dispose();
                    }
                    else
                    {
                        
                        sqlEquipe = "select nodisques,titredisque, nomartiste, anneedisque, nomcategorie from disques inner join CATEGORIEDISQUE on categoriedisque.codecategorie = disques.CODECATEGORIE where nomcategorie = '" + CB_Recherche.Text + "' and titredisque like '" + TB_Recherche.Text.Trim() + "%'";
                        OracleDataAdapter adapter = new OracleDataAdapter(sqlEquipe, conn);

                        if (dataSet.Tables.Contains("listeDisque"))
                        {
                            dataSet.Tables["listeDisque"].Clear();
                        }

                        adapter.Fill(dataSet, "listeDisque");
                        BindingSource source;
                        source = new BindingSource(dataSet, "listeDisque");
                        DGV_Disque.DataSource = source;
                        adapter.Dispose();
                    }
                }
                else if (CB_Recherche.SelectedIndex == 0)
                {
                    DGV_Disque.DataSource = null;
                    if (TB_Recherche.Text.Trim() == "")
                    {
                        remplirDisque();
                    }
                    else
                    {
                        string sqlEquipe = "select nodisques,titredisque, nomartiste, anneedisque, nomcategorie from disques inner join CATEGORIEDISQUE on categoriedisque.codecategorie = disques.CODECATEGORIE where titredisque like '" + TB_Recherche.Text.Trim() + "%'";
                        OracleDataAdapter adapter = new OracleDataAdapter(sqlEquipe, conn);

                        if (dataSet.Tables.Contains("listeDisque"))
                        {
                            dataSet.Tables["listeDisque"].Clear();
                        }

                        adapter.Fill(dataSet, "listeDisque");
                        BindingSource source;
                        source = new BindingSource(dataSet, "listeDisque");
                        DGV_Disque.DataSource = source;
                        adapter.Dispose();
                    }

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TB_Recherche_TextChanged(object sender, EventArgs e)
        {
            rechercheDisque();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM disques WHERE nodisques = "+ Convert.ToInt32(DGV_Disque.CurrentRow.Cells[0].Value);
            OracleCommand oraAjoutDiv = new OracleCommand(sql, conn);
            int n = oraAjoutDiv.ExecuteNonQuery();
            remplirDisque();
            MessageBox.Show(n + " ligne retirées");

        }

        private void DGV_Disque_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            modifierDisque();
        }

        private void DGV_Disque_SelectionChanged_1(object sender, EventArgs e)
        {
            if (DGV_Disque.CurrentCell != null)
            {
                if (DGV_Disque.CurrentCell.RowIndex >= 0)
                {
                    BT_Modifier.Enabled = true;
                }
            }
            
        }

        private void BT_Precedent_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet, "listedisque"].Position -= 1;

        }

        private void BT_Suivant_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet, "listedisque"].Position += 1;
        }
    }
}
