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
    public partial class Act2 : Form
    {
        MySqlConnection conn;
        public Act2()
        {
            InitializeComponent();
        }
        static class BDconn
        {
            public static MySqlConnection GetDBConnection()
            {
                string host = "10.90.12.110";
                //string host = "caseum.ru";
                string port = "33333";
                string database = "is_1_20_st16_KURS";
                string username = "st_1_20_16";
                string password = "44247229";
                string connString = $"server={host};port={port};user={username};database={database};password={password};";
                MySqlConnection conn = new MySqlConnection(connString);
                return conn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        conn.Open();
        conn.Close();
        }

        private void Act2_Load(object sender, EventArgs e)
        {
            conn = BDconn.GetDBConnection();
        }
    }
}
