using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
          var engine = new EscuelaEngine();
            engine.inicializar();
            
            ImprimirCursosEscuela(engine.Escuela);

            //delegados
            engine.Escuela.Cursos.RemoveAll(delegate(Curso cur)
            {
                return cur.Nombre == "301";
            });
            //expresion lambda
            engine.Escuela.Cursos.RemoveAll((Curso cur) => cur.Nombre =="501");
            
            ImprimirCursosEscuela(engine.Escuela);
            Console.WriteLine(new string('=', 50));

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
            
            Console.WriteLine(new string('=',50));
            Console.WriteLine("Cursos de la Escuela");
            Console.WriteLine(new string('=', 50));

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
