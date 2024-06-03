using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Asignatura> Asignaturas { get; set; }

        public List<Evaluaciones> Evaluaciones { get; set; }

        public Alumno()
        {
            this.UniqueId = Guid.NewGuid().ToString();

           this.Evaluaciones = new List<Evaluaciones>() { };
        }

        
    }
}
