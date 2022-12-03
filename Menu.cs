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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Act1 act1 = new Act1();
            act1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Act2 act2 = new Act2();
            act2.ShowDialog();
        }
    }
}
