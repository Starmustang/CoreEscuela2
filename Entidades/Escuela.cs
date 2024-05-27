using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreEscuela.Entidades
{
    internal class Escuela
    {        
            public string Nombre { get; set; }

            public int AñoDeCreacion { get; set; }

            public string Pais { get; set; }

            public string Ciudad { get; set; }

        //<summary>
        //Esta es la forma que estoy acostumbrado en crear los constructores
        //<summary>
        /*public Escuela(string nombre, int AñoDeCreacion)
        //{
        //    this.Nombre = nombre;
        //    this.AñoDeCreacion = AñoDeCreacion;
        //}
        */

        //<summary>
        //Esta es la forma reducida de hacer un constructor, similar a una expresion lambda
        //<summary>


        public Escuela(string nombre, int añoDeCreacion) => (Nombre, AñoDeCreacion) = (nombre, añoDeCreacion);
    }

}
    

