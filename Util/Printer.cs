using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            //Console.WriteLine("".PadLeft(tam, '*'));
            WriteLine(new string('=', tam));
        }

        public static void DibujarTitulo(string titulo)
        {
            var tam = titulo.Length + 4;
            DibujarLinea(tam);
            WriteLine($"| {titulo} |");
            DibujarLinea(tam);
        }

        public static void Beep2(int hrz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hrz, tiempo);
            }
        }

    }
}
