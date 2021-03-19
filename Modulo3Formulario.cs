/*
 * Título: ParcialCorte1
 * @autor Anjllmi Miguel Páez
 * @version 1000r-121033173
 * 
 * Clase dedicada a la solución del Modulo 3 - Cuenta letras:
 *      El programa permitirá ingresar un frase o palabra y la letra
 *      que queremos contar y mostrar cuantas veces esta esta letra 
 *      en la frase. Por ejemplo, para la frase “HOLA MUNDO” y la 
 *      letra “O” deberá mostrar como resultado 2.
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
    public partial class Modulo3Formulario : Form
    {
        
        public Modulo3Formulario(){InitializeComponent();}

        private void Modulo3Formulario_Load(object sender, EventArgs e){ }

        private void Bot_ContarLetras_Click(object sender, EventArgs e)
        {
            string texto = CajTex_Texto.Text;
            int letrasContadas = 0;
            //Se convierte el campo string CajTex_Letra a tipo char:
            char letra = Convert.ToChar(CajTex_Letra.Text.Substring(0, 1));

            /*Se cuentan las letras recorriendo el texto y, cuando
             * un caracter del texto coincide con "letra" se aumenta
             * el contador "letrasContadas".*/
            for (int i = 0; i < texto.Length-1; i++)
            {
                char letraExtraida =
                    Convert.ToChar(CajTex_Texto.Text.Substring(i,1));

                if (letraExtraida == letra) { letrasContadas++; }
            }

            MessageBox.Show
            (
                "Se contaron "+letrasContadas+" letras ( "+letra+" ) en lo que "
                +"escribiste.","Letras contadas",
                MessageBoxButtons.OK, MessageBoxIcon.None
            );
        }
    }
}
