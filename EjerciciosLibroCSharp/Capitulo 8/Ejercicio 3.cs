using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea.Capitulo_8
{
    class Ejercicio_3
    {
        public static void FormatoHora()
        {
            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));


            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.ReadKey();
        }
    }
}
