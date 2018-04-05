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
            //DGV_Disque.Rows.Add(0, 0, 0);
            //DGV_Disque.Rows.Add(0, 0, 0);

        }
        public Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection();



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
       

        private void DGV_Disque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modifierDisque();

            //MessageBox.Show(e.RowIndex.ToString());
        }

        private void DGV_Disque_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV_Disque.CurrentCell.RowIndex >= 0)
            {
                BT_Modifier.Enabled = true;
            }
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            var popup = new AjouterForm(conn);
            DialogResult dialogresult = popup.ShowDialog();

        }

        private void BT_Modifier_Click(object sender, EventArgs e)
        {
            modifierDisque();

        }

        void modifierDisque()
        {
            var popup = new Modifier(conn, Convert.ToInt32(DGV_Disque.CurrentRow.Cells[0].Value));
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
            string sqlEquipe = "select nodisques,titredisque, nomartiste, anneedisque, nomcategorie from disques inner join CATEGORIEDISQUE on categoriedisque.codecategorie = disques.CODECATEGORIE order by nodisques";
            DGV_Disque.Rows.Clear();
            try
            {
                OracleCommand listeEquipe = new OracleCommand(sqlEquipe, conn);

                listeEquipe.CommandType = CommandType.Text;
                OracleDataReader equipeReader = listeEquipe.ExecuteReader();
                while (equipeReader.Read())
                {
                    DGV_Disque.Rows.Add(equipeReader.GetDecimal(0), equipeReader.GetString(1), equipeReader.GetString(2), equipeReader.GetDecimal(3), equipeReader.GetString(4));
                }
                equipeReader.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            remplirDisque();
        }
    }
}
