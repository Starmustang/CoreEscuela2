using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Wilson Academy ", 2001);
            
            Console.WriteLine(escuela.Nombre + escuela.AñoDeCreacion);
            Console.ReadKey();
        }
    }
}
