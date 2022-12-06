using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_20_BolotovaAA_U
{
    public partial class Task3 : Form
    {
        connection connec = new connection();
        public Task3()
        {
            InitializeComponent();
        }
        public static string ConnStr = "server=chuc.caseum.ru;port=33333;user=st_2_20_4;database=is_2_20_st4_KURS;password=65655604;";
        MySqlConnection co = new MySqlConnection(ConnStr);
        private void Task3_Load(object sender, EventArgs e)
        {
            co.Open();
            connec.Met(dataGridView1, co);


            co.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(connec.Data(ConnStr));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
