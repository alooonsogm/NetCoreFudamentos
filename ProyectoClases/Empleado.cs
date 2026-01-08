using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio.");
            this.SalarioMinimo = 1600;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones() Empleado");
            return 30;
        }

        public Empleado(string nombre, string apellidos) : base("hola", "hola")
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con dos parametros.");
        }
    }
}
