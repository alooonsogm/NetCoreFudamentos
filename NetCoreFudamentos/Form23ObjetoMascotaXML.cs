using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFudamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;

        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.edad = int.Parse(this.txtEdad.Text);
            // Convertir la imagen a bytes
            if (this.openFileDialog1.FileName != "")
            {
                mascota.Imagen = File.ReadAllBytes(this.openFileDialog1.FileName);
            }

            //Las clases que se utilizan son de tipo stream, para escribir necesitamos la clase streamWriter.
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.pictureBox1.Image = null;
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.edad.ToString();
                // Convertir bytes a imagen
                if (mascota.Imagen != null)
                {
                    using (MemoryStream ms = new MemoryStream(mascota.Imagen))
                    {
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
