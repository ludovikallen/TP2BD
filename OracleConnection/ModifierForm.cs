using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            LB_Id.Text = numId.ToString();
        }
    }
}
