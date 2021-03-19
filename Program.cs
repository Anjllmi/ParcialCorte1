using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialCorte1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Menu());
            /*
            Application.Run(new Modulo1Formulario());
            Application.Run(new Modulo3Formulario());
            Application.Run(new Modulo5Formulario());
            Application.Run(new Modulo 2());
            Application.Run(new Modulo 4());
            Application.Run(new Modulo 6());
            */
            /*
            Application.Run(new Modulo2());
            Application.Run(new Modulo4());
            //Application.Run(new Modulo_6());*/


        }
    }
}
