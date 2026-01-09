using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        //Queremos alamacenar de forma fisica las mascotas en files
        private HelperFiles helper;
        private string path;

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }

        //Convertir el string del read a list.
        private void ConvertirMascotasList(string data)
        {
            this.Mascotas.Clear();
            //Separamos cada mascota con @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //Separamos las prpiedades
                string[] propiedades = stringMascota.Split(',');
                //CONVERTIMOS EL STRING EN OBJETOS
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //Convertir la coleccion a string
        private string ConvertirMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //Separamos las propiedades menidnate ,
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //Separamos cada objeto string de mascota.
                data += propiedades + "@";
            }
            data = data.Trim('@');
            return data;
        }

        //El programador escribe read y leemos un string y rellenamos la coleccion de mascotas.
        public async Task ReadMascotasAsync()
        {
            //Leemos el fichero de mascotas
            string data = await this.helper.ReadFileAsync(this.path);
            this.ConvertirMascotasList(data);
        }

        //El programador escriba write y guardamos las mascotas.
        public async Task WriteMascotasAsync()
        {
            //Convertimos la coleccion a string.
            string data = this.ConvertirMascotasString();
            //Escribimos los datos en file.
            await this.helper.WriteFileAsync(this.path, data);
        }
    }
}
