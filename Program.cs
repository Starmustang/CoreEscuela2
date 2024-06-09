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
            var listaObjetos = engine.GetObjetoEscuela(
            out int conteoEvaluaciones,
            out int conteoCursos,
            out int conteoAsignaturas,
            out int conteoAlumnos
                );

        

            //engine.Escuela.LimpiarLugar();

            ReadKey();
        }
        #region metodos de impresion
        private static void ImprimirAlumnosmoderno(Escuela escuela)
        {
            Printer.DibujarTitulo("Notas de Alumnos ");
            if (escuela?.Cursos != null)
            {
                foreach (var Curso in escuela.Cursos)
                {
                    foreach (Asignatura laAsignatura in Curso.Asignaturas)
                    {
                        Printer.DibujarTitulo($"Curso: \"{Curso.Nombre}\", Alumnos: \"{Curso.Alumnos.Count}\", Asignatura: \"{laAsignatura.Nombre}\"");
                        var cont = 1;
                        foreach (var ElAlumno in Curso.Alumnos)
                        {
                            Console.WriteLine($"{cont}, - Alumno \"{ElAlumno.Nombre}\", IdUnico: \"{ElAlumno.UniqueId}\"");
                            var temp = new List<Evaluacion>();
                            temp.AddRange(ElAlumno.Evaluaciones.Where((n => n.Asignatura.Nombre == laAsignatura.Nombre && n.Alumno.UniqueId == ElAlumno.UniqueId)));
                            foreach (var evaluaciones in temp)
                            {
                                Console.WriteLine($"Nombre: \"{evaluaciones.Nombre}\", Nota: \"{evaluaciones.Nota}\" 1");
                            }
                            cont++;
                        }
                    }
                }
                Printer.DibujarLinea(50);
            }
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
        #endregion 
    }
}
