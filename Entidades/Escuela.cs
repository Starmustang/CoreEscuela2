using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    internal class Escuela
    {        
            // atributos
            public string Nombre { get; set; }

            public int AñoDeCreacion { get; set; }

            public string Pais { get; set; }

            public string Ciudad { get; set; }
            
        //lo hice de TipoEscuela para que solo se puedan seleccionar las opciones del enum
            public TiposEscuela TipoDeEscuela { get; set; }

        //<summary>
        //Esta es la forma que estoy acostumbrado en crear los constructores

        /*public Escuela(string nombre, int AñoDeCreacion)
        //{
        //    this.Nombre = nombre;
        //    this.AñoDeCreacion = AñoDeCreacion;
        //}
        */
        //<summary>

        //<summary>
        //Esta es la forma reducida de hacer un constructor, similar a una expresion lambda
        //<summary>


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
    }

}
    

