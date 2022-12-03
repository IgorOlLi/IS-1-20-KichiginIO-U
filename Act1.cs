using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_20_KichiginIO_U
{
    public partial class Act1 : Form
    {
        public Act1()
        {
            InitializeComponent();
        }
        abstract class Scrap
        {
            public string year;
            public int price;
            public Scrap()
            {
                year = "2022";
                price = 99;
            }
            public static string Display(string year, int price)
            {
                return $"";
            }
        }
        class HDD : Scrap
        {
            string spin;
            string inter;
            string data;
            object artik;
            public string Spin
            {
                get { return spin; }
                set { spin = value; }
            }
            public string Inter
            {
                get { return inter; }
                set { inter = value; }
            }
            public string Data
            {
                get { return data; }
                set { data = value; }
            }
            public HDD()
            {
                Spin = spin;
                Inter = inter;
                Data = data;
            }
            public static string Display(string year, int price, string spin, string inter, string data)
            {
                return $"Жесткий диск {year} года выпуска, память {data}, кол-во оборотов {spin}, интерфейс {inter}, стоимостью {price}";
            }
        }
        HDD hDD = new HDD();
        class GPU : Scrap
        {
            int freq;
            string comp;
            string data;
            public int Freq
            {
                get { return freq; }
                set { freq = value; }
            }
            public string Comp
            {
                get { return comp; }
                set { comp = value; }
            }
            public string Data
            {
                get { return data; }
                set { data = value; }
            }
            public GPU()
            {
                Freq = freq;
                Comp = comp;
                Data = data;
            }
            public static string Display(string year, int price, int freq, string comp, string data)
            {
                return $"Видиокарта {year} года выпуска, частота {freq}, производитель {comp}, видеопамять {data}, стоимостью {price}";
            }
        }
        GPU gPU = new GPU();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            label3.Text = "Частота";
            label4.Text = "Производитель";
            label5.Text = "Видеопамять";
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            label3.Text = "Память";
            label4.Text = "Кол-во оборотов";
            label5.Text = "Интерфейс";
            button4.Enabled = true;
            button3.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                gPU.year = textBox1.Text;
                gPU.price = Convert.ToInt32(textBox2.Text);
                gPU.Freq = Convert.ToInt32(textBox3.Text);
                gPU.Comp = textBox4.Text;
                gPU.Data = textBox5.Text;
                listBox1.Items.Add(GPU.Display(gPU.year, gPU.price, gPU.Freq, gPU.Comp, gPU.Data));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                hDD.year = textBox1.Text;
                hDD.price = Convert.ToInt32(textBox2.Text);
                hDD.Spin = textBox3.Text;
                hDD.Inter = textBox4.Text;
                hDD.Data = textBox5.Text;
                listBox1.Items.Add(HDD.Display(hDD.year, hDD.price, hDD.Spin, hDD.Inter, hDD.Data));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Вы ввели неверные данные");
            }
        }
    }
}
