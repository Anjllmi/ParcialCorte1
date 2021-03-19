/*
 * Título: ParcialCorte1
 * @autor Anjllmi Miguel Páez
 * @version 1000r-121033173
 * 
 * Clase dedicada a la solución del Modulo 5- Pangramas
 *      Seguro que has visto textos como "The quick brown fox jumps
 *      over the lazy dog" o "El veloz murciélago hindú comía feliz 
 *      cardillo y kiwi. La cigüeña tocaba el saxofón detrás del 
 *      palenque de paja". Son "pangramas", textos que contienen 
 *      todas las letras de un cierto alfabeto, quizá repetidas.
 *      
 *      Deberás crear un programa que reciba varias frases y que 
 *      diga si cada una de ellas es un pangrama o no. Sólo deberás 
 *      considerar las letras del alfabeto inglés (no te preocupes 
 *      por las tildes, ni la eñe, entre otras), pero podrán aparecer 
 *      en mayúsculas o en minúsculas.
 *      
 *      Para cada frase deberás responder SI cuando se trate de un pangrama o NO
 *      cuando no lo sea.
 *      
 *      Para la validación deberá optimizar el código haciendo validación por código ascii
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
    public partial class Modulo5Formulario : Form
    {
        public Modulo5Formulario(){InitializeComponent();}

        private void Modulo5Formulario_Load(object sender, EventArgs e){}

        private void Bot_ValidarPangramas_Click(object sender, EventArgs e)
        {
            //Inicialización de atributos:
            string texto1 = CajTex_Texto1.Text;
            string texto2 = CajTex_Texto2.Text;
            string texto3 = CajTex_Texto3.Text;

            EsPangrama(texto1,1);
            EsPangrama(texto2,2);
            EsPangrama(texto3,3); 
        }


        /*Evalúa si una texto es un pangrama o no, y actualiza la
         * etiqueta "Eti_Respuesta..."(label) respectiva de acuerdo 
         * al resultado.*/
        public void EsPangrama(string texto,int etiqueta)
        {
            //Inicialización de variables:

            /*Entero para contar la cantidad de elementos registrados
             * en el arreglo "asciiRegistrados"*/
            int contador = 0;

            /*Booleano para verificar si ya se ha registrado un codigo
             Ascii igual en el arrreglo "ascii>Registrados"*/
            bool estaRegistrado = false;

            /*Entero que representa el codigo Ascii del caracter 
             * extraído del texto.*/
            int codigoAscii = 0;

            //Incialización de arreglos:

            /*Arreglo de enteros para registrar las letras únicas del
             * alfabeto inglés halladas en el texto.*/
            int[] asciiRegistrados = new int[26];


            /*Cilo que analiza letra por letra del texto si pertenece
             * al alfabeto inglés y si ya está registrada en 
             * "asciiRegistrados"*/
            for (int iCaracter = 0; iCaracter < texto.Length && 
                    asciiRegistrados[25] == 0; iCaracter++)
            {
                /*Se extrae el codigo Ascii del caracter en la
                posición iCaracter del texto.*/
                codigoAscii = ExtraerCodigoAscii(texto, iCaracter);

                /*Se verifica si el código extraído está en el rango 
                del alfabeto inglés.*/
                if (PerteceAsciiAlfabeto(codigoAscii))
                {
                    //Se verifica que el arreglo asciiRegistrados no esté vacío.
                    if (asciiRegistrados.Sum() > 0)
                    {
                        estaRegistrado = false;
                        int i = 0;

                        /*Se verifica si el código extraído ya está 
                        registrado.*/
                        for (i = 0; i < asciiRegistrados.Length && 
                                estaRegistrado == false && asciiRegistrados[i] != 0; i++)
                        {
                            if (codigoAscii == asciiRegistrados[i])
                            {
                                estaRegistrado = true;
                            }
                            else if (codigoAscii == 
                                    ObtenerCodigoEquivalente(asciiRegistrados[i]))
                            {
                                estaRegistrado = true;
                            }
                            else
                            {
                                estaRegistrado = false;
                            }
                        }//for

                        /*@deprecated Este MessageBox se usaba con fines de diganóstico:*/
                        /*
                        MessageBox.Show("\ni=" + (i-1) + "\n" + codigoAscii 
                                + " == " + asciiRegistrados[i-1] + "?\n" +
                                codigoAscii + " == " + codigoAsciiEquivalente + "?" +
                                 "\nr=" + estaRegistrado, "x", MessageBoxButtons.OK, 
                                MessageBoxIcon.None);
                        */

                        /*Se registra el código Ascii de la letra del
                        alfabeto nueva en el arreglo si no está 
                        regitrado.*/
                        if (estaRegistrado == false)
                        {
                            asciiRegistrados[i] = codigoAscii;
                            contador++;
                        }
                    }
                    else
                    {
                        asciiRegistrados[0] = codigoAscii;
                        contador++;
                    }
                }
            }

            /*Se verifica que se hayan registrado las 26 letras del 
             * alfabeto inglés en el arreglo, de ser así, se afirma
             que el texto es un pangrama.*/


            if (contador == 26) {

                switch (etiqueta)
                {
                    case 1:
                        Eti_Respuesta1.Text = "SÍ";
                        break;

                    case 2:
                        Eti_Respuesta2.Text = "SÍ";
                        break;

                    case 3:
                        Eti_Respuesta3.Text = "SÍ";
                        break;


                    default:
                        break;
                }
                
                
            }
            else {

                switch (etiqueta)
                {
                    case 1:
                        Eti_Respuesta1.Text = "NO";
                        break;

                    case 2:
                        Eti_Respuesta2.Text = "NO";
                        break;

                    case 3:
                        Eti_Respuesta3.Text = "NO";
                        break;


                    default:
                        break;
                }

            }

            /* @deprecated Este ciclo se usaba con fines de 
             * diagnóstico*/
            /*
            string x = "";
            foreach (int asciiX in asciiRegistrados)
            {
                x += asciiX + "/" + (char)asciiX + ", ";
            }
            Eti_Respuesta2.Text = x;
            */
        }


        /*@return Retorna el código Ascii extraído de un caracter 
         * espeíficode un texto como un número entero. */
        public int ExtraerCodigoAscii(string texto, int indice)
        {
            return Encoding.ASCII.GetBytes(texto)[indice];
        }

        /*@return Devuleve verdadero si el código Ascii ingresado
         * está en el rango de caracteres del alfabeto inglés como
         * letras mayúsculas.
         */
        bool PerteneceAsciiMayusculas(int codigoAscii)
        {
            return codigoAscii >= 65 && codigoAscii <= 90;
        }

        /*@return Devuleve verdadero si el código Ascii ingresado
         * está en el rango de caracteres del alfabeto inglés como
         * letras minúsculas.
         */
        bool PerteneceAsciiMinusculas(int codigoAscii)
        {
            return codigoAscii >= 97 && codigoAscii <= 122;
        }

        /*@return Devuelve verdadero si el código Ascii ingresado
         * está en el rango de las letras del alfabeto inglés.
         */
        bool PerteceAsciiAlfabeto(int codigoAscii)
        {
            return PerteneceAsciiMayusculas(codigoAscii) || 
                PerteneceAsciiMinusculas(codigoAscii);
        }

        /*@return Devuelve el código Ascii de la variante mayúscula
         * equivalente del código de una letra  minúcula y viceversa
         * que esté dentro del alfabeto inglés.
         */
        public int ObtenerCodigoEquivalente(int codigoAscii) {

            if (PerteneceAsciiMayusculas(codigoAscii))
            {
                return 97 + (25 - (90 - codigoAscii));


            }
            else if (PerteneceAsciiMinusculas(codigoAscii))
            {
                return 65 + (25 - (122 - codigoAscii));
            }
            else return 0;
        }
    }
}


  
