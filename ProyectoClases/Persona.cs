using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    #region ENUMERACIONES

    //Las enumeraciones estan dentro del namespace.
    public enum TipoGenero { Masculino = 0, Femenino = 1 }
    public enum Paises { España, Francia, Alemania, Andorra, Colombia }

    #endregion

    public class Persona
    {
        #region CONSTRUCTOR

        public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacia");
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor PERSONA con dos parametros.");
        }

        #endregion

        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                //Devolvemos una descripcion aleatoria de nuestro numero
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripcion " + dato;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomilicioVacaciones { get; set; }

        public TipoGenero _Genero;

        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Donde vas listo...");
                } else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //Campo de propiedad.
        private int _Edad;

        public int Edad
        {
            //En el get devolvemos el valor.
            get { return this._Edad; }
            //Establecemos un valor.
            set
            {
                if (value < 0)
                {
                    //No nos gusta. ERROR
                    throw new Exception("La edad no puede ser negativa.");
                } else
                {
                    this._Edad = value;
                }
            }
        }

        #endregion

        #region METODOS

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Nombre + " " + this.Apellidos).ToUpper();
        }

        public string GetNombreCompleto(int num1, int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }

        public void GetNombreCompleto(string dato) { }

        #endregion
    }
}
