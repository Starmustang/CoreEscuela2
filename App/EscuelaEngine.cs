using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public sealed class EscuelaEngine //sealed permite instanciar pero no heredar
    {
        public Escuela Escuela { get; set; }

              
        public EscuelaEngine()
        {
            

        }

        

        public void inicializar()
        {
            Escuela = new Escuela("Wilson Academy ", 2001, TiposEscuela.PreEscolar, pais: "Republica Dominicana", ciudad: "Santo Domingo");

            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();           
            

            
        }

        
        private void CargarAsignaturas()
        {
            
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre = "Educacion Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias naturales"}, //, Evaluacion=(rnd.NextDouble() *(5))
                };
                curso.Asignaturas = listaAsignaturas;
            }
            
        }


        private void CargarEvaluaciones()
        {        
            var lista = new List<Evaluacion>();
            foreach (var curso in Escuela.Cursos )
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        Random rnd = new Random(System.Environment.TickCount);

                        for (int i = 0;  i < 5;  i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} EV#{i + 1}",
                                Nota = (double)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }

            }
            
        }



        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}"};

            return listaAlumnos.OrderBy((al)=> al.UniqueId).Take(cantidad).ToList();
        }

        private void CargarCursos()
        {   
         
            Escuela.Cursos = new List<Curso>()
            {
                new Curso(){Nombre = "101", Jornada = TiposJornada.Mañana},

                new Curso(){Nombre = "201", Jornada = TiposJornada.Mañana},

                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},

                new Curso(){Nombre = "401", Jornada = TiposJornada.Tarde},

                new Curso(){Nombre = "501", Jornada = TiposJornada.Mañana},

                new Curso{Nombre = "501", Jornada = TiposJornada.Tarde}
            };

            Random rnd = new Random();

            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(5, 50);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom); //llena cursos con alumnos

            }
        }


    }
}
