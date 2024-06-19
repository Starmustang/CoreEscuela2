using CoreEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.App
{
    public  class Reporteador
    {
        Dictionary<Llave_Diccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;
        public  Reporteador(Dictionary<Llave_Diccionario, IEnumerable<ObjetoEscuelaBase>> dicObEsc)
        {
            if (dicObEsc == null)
            {
                throw new ArgumentNullException(nameof(dicObEsc));
            }
            _diccionario = dicObEsc;
        }

        public IEnumerable<Evaluacion> GetListaEvaluacion()
        {
            
            if(_diccionario.TryGetValue(Llave_Diccionario.Evaluacion, out IEnumerable<ObjetoEscuelaBase> lista))
            {
                return lista.Cast<Evaluacion>();
            }
            else
            {
                return new List<Evaluacion>();
            }
            
        }

        public IEnumerable<string> GetListaAsignaturas()
        {
            return GetListaAsignaturas(out var dummy);
        }


        public IEnumerable<string> GetListaAsignaturas(out IEnumerable<Evaluacion> listaEvaluaciones)
        {
             listaEvaluaciones = GetListaEvaluacion();
            
            return (from Evaluacion ev in listaEvaluaciones                  
                   select ev.Asignatura.Nombre).Distinct();
        }
        public Dictionary<string, IEnumerable<Evaluacion>> GetDicEvaluaXAsig()
        {
            var dicRta = new Dictionary<string, IEnumerable<Evaluacion>>();

            var listaAsig = GetListaAsignaturas(out var listaEvaluaciones);

            foreach (var asig in listaAsig)
            {
                var evalsAsig = from eval in listaEvaluaciones
                                where eval.Asignatura.Nombre == asig
                                select eval;

                dicRta.Add(asig, evalsAsig);
            }

            return dicRta;
        }

        public Dictionary<string, IEnumerable<Object>> GetPromedioAsignatura()
        {
            var rta = new Dictionary<string, IEnumerable<Object>>();
            var dicEvalXAsig = GetDicEvaluaXAsig();

            foreach (var asigConEval in dicEvalXAsig )
            {
                var dummy = from eval in asigConEval.Value
                            group eval by eval.Alumno.Nombre
                            into grupoEvalsAlumno
                           
                            select  new 
                            { 
                               alumnoNombre = grupoEvalsAlumno.Key,
                               promedio = grupoEvalsAlumno.Average(evaluacion=> evaluacion.Nota)

                            };
                
            }

            return rta;
        }
    }
}
