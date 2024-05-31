using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            

        }

        public void inicializar()
        {
            Escuela = new Escuela("Wilson Academy ", 2001, TiposEscuela.PreEscolar, pais: "Republica Dominicana", ciudad: "Santo Domingo");

            CargarCursos();
            CargarAlumnos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{Nombre = "Matematicas"},
                    new Asignatura{Nombre = "Educacion Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias naturales"},
                };
                curso.Asignaturas.AddRange(listaAsignaturas);
            }
        }

        private void CargarAlumnos()
        {
            throw new NotImplementedException();
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
        }
    }
}
