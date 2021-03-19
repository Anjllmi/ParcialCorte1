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
<<<<<<< HEAD
            Application.Run(new Menu());
=======
            Application.Run(new Modulo1Formulario());
            Application.Run(new Modulo3Formulario());
            Application.Run(new Modulo5Formulario());
>>>>>>> Anjllmi
        }
    }
}
