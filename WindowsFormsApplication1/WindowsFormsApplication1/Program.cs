using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            Form1 f = new Form1();
            //cambiamos la dimensiones de form
            f.SetBounds(0, 0, 500, 600);
            //Application.Run(f);
            //Application.Run(new videoAudio());
            //Application.Run(new Fechas());
            Application.Run(new ImagenS());

        }
    }
}
