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
            var escuela = new Escuela("Wilson Academy ", 2001, TiposEscuela.PreEscolar, pais:"Republica Dominicana", ciudad:"Santo Domingo");

            //escuela.TipoDeEscuela = TiposEscuela.Primaria; //aqui me da la opcion de seleccionar uno de los valores dentro de tiposescuela

            var curso1 = new Curso()
            {
                Nombre = "101", 
            };

            var curso2 = new Curso()
            {
                Nombre = "201",
            };

            var curso3 = new Curso()
            {
                Nombre = "301",
            };

            Console.WriteLine(escuela);
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"{curso1.Nombre} , {curso1.UniqueId}");
            Console.WriteLine($"{curso2.Nombre} , {curso2.UniqueId}");
            Console.WriteLine($"{curso3.Nombre} , {curso3.UniqueId}");
            Console.WriteLine(new string('=', 50));//cw y tab es un atajo para hacer el console.writeline
            Console.ReadKey();
        }
    }
}
