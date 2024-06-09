using CoreEscuela.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase, ILugar
    {
        // atributos

           

            public int AñoDeCreacion { get; set; }

            public string Pais { get; set; }

            public string Ciudad { get; set; }

            public string Direccion { get; set; }

        //lo hice de TipoEscuela para que solo se puedan seleccionar las opciones del enum
        public TiposEscuela TipoDeEscuela { get; set; }

            public List<Curso> Cursos { get; set; }    


        public Escuela(string nombre, int añoDeCreacion) => (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);

        public Escuela(string nombre, int añoDeCreacion, TiposEscuela tipo, string pais="", string ciudad = "")
        {
            (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);
            Pais = pais;
            Ciudad = ciudad;
        }

        //lo que esto hace es sobreescribir  este objeto para imprimir lo que deceo de el.
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TipoDeEscuela} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }

        public void LimpiarLugar()
        {
            
            Printer.DibujarLinea();
            Printer.Beep2(1000, cantidad:3);
            Console.WriteLine("Limpiando establecimiento....");

            Cursos.ForEach(a => a.LimpiarLugar());

            Printer.DibujarTitulo($"Escuela {Nombre} Limpia");
        }
    }

}
    

