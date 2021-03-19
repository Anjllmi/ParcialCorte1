using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialCorte1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo1Formulario nuevo = new Modulo1Formulario();
            nuevo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo3Formulario nuevo = new Modulo3Formulario();
            nuevo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modulo5Formulario nuevo = new Modulo5Formulario();
            nuevo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //modulo2 nuevo = new modulo2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //modulo4 nuevo = new modulo4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //modulo6 nuevo = new modulo6();
        }
    }
}
