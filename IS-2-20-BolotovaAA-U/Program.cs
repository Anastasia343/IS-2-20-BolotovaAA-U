using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IS_2_20_BolotovaAA_U
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
    }

    public class connection
    {
        public string Data(string cont)
        {
            return cont;
        }
        public void Met(DataGridView grid, MySqlConnection co)
        {
            string bol = ;
            MySqlCommand a = new MySqlCommand(bol, co);
            MySqlDataReader read = a.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (read.Read())
            {
                data.Add(new string[8]);
                data[data.Count - 1][0] = read[0].ToString();
                data[data.Count - 1][1] = read[1].ToString();
                data[data.Count - 1][2] = read[2].ToString();
                data[data.Count - 1][3] = read[3].ToString();
                data[data.Count - 1][4] = read[4].ToString();
                data[data.Count - 1][5] = read[5].ToString();
                data[data.Count - 1][6] = read[6].ToString();
                data[data.Count - 1][7] = read[7].ToString();
            }
            foreach (string[] vi in data)
                grid.Rows.Add(vi);

            
        }




    }
}
