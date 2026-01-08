using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor director.");
            this.SalarioMinimo = this.SalarioMinimo + 200;
        }

        //Metodo sobrescrito
        public override int GetDiasVacaciones()
        {
            //Llamamos al metodo del empleado.
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetDiasVacaciones() Director");
            return vacasEmpleado + 8;
        }
    }
}
