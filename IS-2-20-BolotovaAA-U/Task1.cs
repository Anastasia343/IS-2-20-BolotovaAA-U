using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_20_BolotovaAA_U
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_Load(object sender, EventArgs e)
        {
            Accessories accessories = new Accessories();
            accessories.price = 566;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
