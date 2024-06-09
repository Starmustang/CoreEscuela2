using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    [DebuggerDisplay("{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}")]
    public class Evaluacion: ObjetoEscuelaBase
    {
        

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }

        public double Nota { get; set; }

       
    }
}
