using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

        public Direccion()
        {
            Debug.WriteLine("Constructor sin parametros");
        }

        public Direccion(string calle, string ciudad)
        {
            //Inicializamos las variables.
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor DIRECCION con dos parametros");
        }

        public Direccion(string calle, string ciudad, int codigoPostal)
        {
            //Inicializamos las variables.
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = codigoPostal;
            Debug.WriteLine("Constructor DIRECCION con tres parametros");
        }
    }
}
