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
    public partial class Modulo_4 : Form
    {
        public Modulo_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string original = txtPalabra.Text;
            string invertido = "";

            for (int i = original.Length - 1; i >= 0; i--)
            {
                invertido += original.Substring(i, 1);
            }

            MessageBox.Show("Invertido: " + invertido + " ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
