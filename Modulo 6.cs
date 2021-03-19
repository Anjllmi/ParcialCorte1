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
    public partial class Modulo_6 : Form
    {
        public Modulo_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string original = texto.Text;

            //Vector donde guardaremos cada numero
            int[] numeros = new int[10];//100 numeros

            //Para concatenar los digitos del numero
            string numero = "";

            int ind = 0;

            int caracter = 0;


            //Ciclo que recorre el vector "numeros"
            for (int nuevoNumero = 0; nuevoNumero < numeros.Length; nuevoNumero++)
            {

                //Ciclo que recorre cada caracter del string "orignal"
                /*Este cilo se rompe cuando el indice "caracter" esta fuera de la longitud del texto
                * Ó si el caracter es un espacio " ".
                */
                for (caracter = ind; caracter < original.Length && original.Substring(caracter, 1) != " "; caracter++)
                {

                    //Se omiten los caracteres puntos, pues no nos interesan.
                    if (original.Substring(caracter, 1) != ".")
                    {

                        //Se concatenan los digitos del numero
                        numero += original.Substring(caracter, 1);

                    }
                }
                ind = caracter + 1;
                /*Se guarda dentro del elemento en la posición "nuevoNumero" del vector "numeros"
                * el caracter actual (original.Substring(caracter,1)) y se convierte a tipo entero
                * con Convert.Int32(...)
                */
                // Se guarda el numero concatenado en la posicion indicada por "nuevoNumero"
                Int32.TryParse(numero, out numeros[nuevoNumero]);


                //se vacia el valor de "numero"
                numero = "";
            }
            int i = 0;

            foreach (int numeroN in numeros)
            {

                MessageBox.Show("Numero " + i + "=" + numeroN, " ", MessageBoxButtons.OK, MessageBoxIcon.None);
                i++;
            }

            /*Se muestra la suma total de los numeros usando el metodo numeros.Sum() en un MessageBox*/
            MessageBox.Show("cantidad de numeros = " + numeros.Length + "Suma =  " + numeros.Sum(), "Suma total", MessageBoxButtons.OK, MessageBoxIcon.None);

            numeros.Sum();
        }
    }
}
