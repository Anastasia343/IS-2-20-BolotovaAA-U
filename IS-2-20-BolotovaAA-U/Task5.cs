using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IS_2_20_BolotovaAA_U
{
    public partial class Task5 : Form
    {
        public static string ConnStr = "server=chuc.caseum.ru;port=33333;user=st_2_20_4;database=is_2_20_st4_KURS;password=65655604;";
        Connect getConn = new Connect(ConnStr);
        MySqlConnection connect = new MySqlConnection(Connect.RetStr());
        public Task5()
        {
            InitializeComponent();
        }

        private void Task5_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBox1, "ID");
            toolTip1.SetToolTip(textBox2, "ФИО");
            toolTip1.SetToolTip(textBox3, "Дата рождения YYYY.MM.DD"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT t_uchebka_BOLOTOVA(idStud, fioStud, datetimeStud) VALUES({Convert.ToInt32(textBox1.Text)},'{textBox2.Text}','{textBox3.Text}')";

                connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Запись в БД создана");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
