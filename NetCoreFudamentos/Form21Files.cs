using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using ProyectoClases.Helpers;

namespace NetCoreFudamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
            //Cuando hablamos de rutas o caracteres especiales, dentro de string, tenemos dos formas de escribir dichos caracteres.
            //1) C:\carpeta\1.txt -> va a ver que usar doble barra C:\\carpeta\\1.txt
            //2) Utilizar @ antes del string y fuera del string
            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos alamacenados.");
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenidoFile.Text = content;
        }
    }
}
