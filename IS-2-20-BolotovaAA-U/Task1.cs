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
        internal HardDisk hd;
        internal Graphic gp;
        public Task1()
        {
            InitializeComponent();
        }
        public abstract class Access<T>
        {
            T Articul;
            internal decimal Price;
            internal short Year;
            public Access(decimal price, short year)
            {
                Price = price;
                Year = year;
            }
            //public Access()
            //{

            //}
            public abstract void Display(ListBox listbox);
        }
        internal class HardDisk : Access<string>
        {
            //Вращения
            private int turns;
            public int Turns_Sv
            {
                get { return turns; }
                set { turns = value; }
            }
            //
            //Интерфейс(поле)
            private string @interface;
            public string Interface_Sv
            {
                get { return @interface; }
                set { @interface = value; }
            }
            //
            //Объём
            private int size;
            public int Size_Sv
            {
                get { return size; }
                set { size = value; }
            }
            //

            public HardDisk(decimal price, short year, int turns, string @interface, int size) : base(price, year)
            {
                Turns_Sv = turns;
                Interface_Sv = @interface;
                Size_Sv = size;
            }

            public override void Display(ListBox listbox)
            {
                listbox.Items.Add(String.Concat(Enumerable.Repeat("=", 20)));
                listbox.Items.Add($"\nЦена: {this.Price} \tГод: {this.Year}");
                listbox.Items.Add($"Вращения: {Turns_Sv}\tИнтерфейс: {Interface_Sv}\tОбъём: {Size_Sv}");
                listbox.Items.Add(String.Concat(Enumerable.Repeat("=", 20)));
            }
        }
        internal class Graphic : Access<string>
        {
            //Частота
            private double gpu_gh;
            public double GPU_Gh
            {
                get { return gpu_gh; }
                set { gpu_gh = value; }
            }
            //

            //Производитель
            private string maker;
            public string Maker
            {
                get { return maker; }
                set { maker = value; }
            }
            //

            //Объём памяти
            private short gpu_memory;
            public short GPU_Memory
            {
                get { return gpu_memory; }
                set { gpu_memory = value; }
            }
            //

            public Graphic(decimal price, short year, double gPU_Gh, string maker, short gPU_Memory) : base(price, year)
            {
                GPU_Gh = gPU_Gh;
                Maker = maker;
                GPU_Memory = gPU_Memory;
            }

            public override void Display(ListBox listbox)
            {
                listbox.Items.Add(String.Concat(Enumerable.Repeat("=", 20)));
                listbox.Items.Add($"\nЦена: {this.Price} \tГод: {this.Year}");
                listbox.Items.Add($"Частота: {GPU_Gh}\tПроизводитель: {Maker}\tОбъём: {GPU_Memory}");
                listbox.Items.Add(String.Concat(Enumerable.Repeat("=", 20)));

            }
        }
        private void Task1_Load(object sender, EventArgs e)
        {
            //Accessories accessories = new Accessories();
            //accessories.price = 566;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Length == 0 && textBox7.Text.Length == 0 && textBox8.Text.Length == 0)
                {
                    hd.Display(listBox1);
                }
                else if (textBox3.Text.Length == 0 && textBox4.Text.Length == 0 && textBox5.Text.Length == 0)
                {
                    gp.Display(listBox1);
                }
                else
                {
                    MessageBox.Show("Вы ввели неверные данные");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Length == 0 && textBox7.Text.Length == 0 && textBox8.Text.Length == 0)
                {
                    hd = new HardDisk(Convert.ToDecimal(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text));
                }
                else if (textBox3.Text.Length == 0 && textBox4.Text.Length == 0 && textBox5.Text.Length == 0)
                {
                    gp = new Graphic(Convert.ToDecimal(textBox1.Text), Convert.ToInt16(textBox2.Text), Convert.ToDouble(textBox6.Text), textBox7.Text, Convert.ToInt16(textBox8.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
