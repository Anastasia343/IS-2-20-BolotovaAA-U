using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_2_20_BolotovaAA_U
{
   
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        private class ConnectDB
        {
            internal string ReturnConnect(string connect) => connect;
        }
        static string connStr = "server = chuc.caseum.ru;port = 33333;user = uchebka;database= uchebka;password= uchebka;";
        private void Task2_Load(object sender, EventArgs e)
        {
            try
            {
                ConnectDB conn = new ConnectDB();
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                connection.Close();
                MessageBox.Show(conn.ReturnConnect(connStr));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Hide();
            }
            


        }
    }
    
    public class Сonnection
    {
        public string Connstr(string conn) 
        {
            return conn;
        }
        
  
    }
}
