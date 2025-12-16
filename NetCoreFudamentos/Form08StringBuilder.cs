using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFudamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longiud = cadena.Length;
            //Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longiud; i++)
            {
                //Siempre recuepramos la ultima letras
                char letra = cadena[longiud - 1];
                //Eliminamos la ultima letra
                cadena = cadena.Remove(longiud - 1, 1);
                //Insertamos la letras en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamos el proceso.
            krono.Stop();
            //El objeto stopwatch contiene una serie de propiedades para
            //comprobar el tiempo entre el proceso.
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds +
                ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE STRINGBUILDER
            StringBuilder cadena = new StringBuilder();
            //Para añadir contenido tiene un metodo llamado Append
            cadena.Append(this.txtTexto.Text);
            int longiud = cadena.Length;
            //Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longiud; i++)
            {
                //Siempre recuepramos la ultima letras
                char letra = cadena[longiud - 1];
                //Eliminamos la ultima letra
                cadena = cadena.Remove(longiud - 1, 1);
                //Insertamos la letras en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //Finalizamos el proceso.
            krono.Stop();
            //El objeto stopwatch contiene una serie de propiedades para
            //comprobar el tiempo entre el proceso.
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds +
                ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
