using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_KichiginIO_U
{
    public partial class Act3 : Form
    {
        MySqlConnection conn;
        private MySqlDataAdapter MyDA = new MySqlDataAdapter();
        private BindingSource bSource = new BindingSource();
        private DataSet ds = new DataSet();
        private DataTable table = new DataTable();
        string id_selected_rows = "0";
        public Act3()
        {
            InitializeComponent();
        }
        public void GetListUsers()
        {
            string commandStr = "SELECT * " +
                "FROM T_Access " +
                "INNER JOIN T_Empl ON T_Empl.access_Empl = T_Access.id_Access " +
                "INNER JOIN T_Spec ON T_Spec.id_Spec = T_Empl.spec_Empl;";
            conn.Open();
            MyDA.SelectCommand = new MySqlCommand(commandStr, conn);
            MyDA.Fill(table);
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
            conn.Close();
            int count_rows = dataGridView1.RowCount - 1;
            //toolStripLabel2.Text = (count_rows).ToString();
        }

        private void Act3_Load(object sender, EventArgs e)
        {
            conn = Program.DBUtils.GetDBConnection();
            GetListUsers();
        }

    }

}
