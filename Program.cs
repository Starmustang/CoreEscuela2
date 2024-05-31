using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var engine = new EscuelaEngine();
            engine.inicializar();

            Printer.DibujarTitulo("Bienvenidos a la mejor escuela");
            Printer.Beep2();
            ImprimirCursosEscuela(engine.Escuela);
            
            ReadKey();
        }

        private static bool predicado(Curso obj)
        {
            return obj.Nombre == "301";
        }
        /// <summary>
        /// este metodo imprime todos los elementos dentro de cursos
        /// </summary>
        /// <param name="escuela"></param>
        private static void ImprimirCursosEscuela(Escuela escuela)
        {

           
            Printer.DibujarTitulo("Cursos de la Escuela");
            

            if (escuela?.Cursos != null )
            foreach (var curso in escuela.Cursos)
            {
                Console.WriteLine($"Nombre: {curso.Nombre}  Uniqueid: {curso.UniqueId}");
            }
            else
            {
                Console.WriteLine("algo esta vacio");
            }
        }
    }
}
