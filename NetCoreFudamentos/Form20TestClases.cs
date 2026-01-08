using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFudamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Domicilio = new Direccion();
            person.Nombre = "Alumno";
            person.Apellidos = "Reyes";
            person.Edad = 25;

            person[0] = "Vamos 1";
            person[1] = "Vamos 2";
            person.Genero = TipoGenero.Femenino;
            person.Nacionalidad = Paises.España;

            this.lstClases.Items.Add("Nombre: " + person.Nombre + ", Apellidos: " + person.Apellidos + ", Edad: " + person.Edad + ", Genero: " + person.Genero);

            this.lstClases.Items.Add(person.GetNombreCompleto(true));

            person.Domicilio.Calle = "Avenida Enero";
            person.Domicilio.Ciudad = "Madrid";
            person.Domicilio.CodigoPostal = 28304;

            this.lstClases.Items.Add("Direccion: " + person.Domicilio.Calle + " " + person.Domicilio.Ciudad + " " + person.Domicilio.CodigoPostal);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones: " + emp.GetDiasVacaciones() + " dias.");
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacaciones: " + dire.GetDiasVacaciones() + " dias.");
        }
    }
}
