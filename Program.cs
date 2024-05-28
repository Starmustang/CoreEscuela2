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
            escuela.Pais = "Rusia";
            escuela.Ciudad = "Moscow";
            escuela.TipoDeEscuela = TiposEscuela.Primaria; //aqui me da la opcion de seleccionar uno de los valores dentro de tiposescuela
                                                           
           
            Console.WriteLine(escuela);
            Console.ReadKey();
        }
    }
}
