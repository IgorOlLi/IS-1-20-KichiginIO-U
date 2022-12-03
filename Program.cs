using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_1_20_KichiginIO_U
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        static class DBUtils
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
    }
}
