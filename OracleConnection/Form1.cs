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
            DGV_Disque.Rows.Add(0, 0, 0);
        }
        private Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection();



        private void Connecter()
        {
            try
            {
                string dSource =
                    "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 205.237.244.251)(PORT = 1521)) (CONNECT_DATA =(SERVICE_NAME = orcl.clg.qc.ca)))";
                string bd = "Data Source = " + dSource + "; User Id =" + "allenlud" + "; Password = " + "ORACLE1";
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
        
        

        private void DGV_Disque_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
