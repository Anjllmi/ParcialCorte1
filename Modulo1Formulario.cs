/*
 * Título: ParcialCorte1
 * @autor Anjllmi Miguel Páez
 * @version 1000r-121033173
 * 
 * Clase dedicada a la solución del Módulo1,Mayor de dos números:
 *   El usuario introducirá dos números enteros el programa deberá
 *   indicar si el primero o el segundo es el mayor.
 */

//Predeterminado
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
    public partial class Modulo1Formulario : Form
    {
        /*Inicializa dos números enteros.*/
        private int _ent1, _ent2 = 0;

        /*Incializa el formulario nombrado form1*/
        public Modulo1Formulario(){InitializeComponent();}

        /*Carga lo necesario al crear una nueva instancia del 
         * formulario*/
        private void Form1_Load(object sender, EventArgs e){ }

        /*Evalúa y retorna una cadena(string) que describe cuál es el
         * valor mayor entre los dos números enteros ingresados en 
         * los campos.*/
        private void Bot_EncontrarMayor_Click(object sender, EventArgs e)
        {
            if (CNum_Entero1.Value != CNum_Entero2.Value)
            {
                /*Se convierte el valor contenido en los campos numéricos 
                 * del formulario a números enteros*/
                _ent1 = Decimal.ToInt32(CNum_Entero1.Value);
                _ent2 = Decimal.ToInt32(CNum_Entero2.Value);

                //Se evalúa cuál es el número mayor comparádolos.
                string resultado = _ent1 > _ent2 ? _ent1 + " es el número entero " +
                    "mayor." : _ent2 + " es el número entero mayor.";

                MessageBox.Show
                (
                    resultado, "Resultado de comparación", MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show
                (
                    "Los números enteros son iguales.", "Números iguales.",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                );
            } 
        }
    }
}
