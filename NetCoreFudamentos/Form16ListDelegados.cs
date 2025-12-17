using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //Inicializamos la variable contador
            this.contador = 0;
            //Amacenar todos los botones dentro de una nueva coleccion.
            List<Button> botones = new List<Button>();
            //Vamos a añadir dinamicante todos los botones del formulario.
            foreach(Control control in this.Controls)
            {
                //Preguntar por el tipo de control
                if(control is Button)
                {
                    botones.Add((Button)control);
                }
            }
            //Vamos a crear un metodo para que todos los botones lean al ser pulsados.
            foreach(Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            //Queremos acceder al objeto que ha realizado la peticion al metodo.
            //Mediante sender se captura dicho objeto.
            ((Button)sender).BackColor = Color.LightBlue;
        }
    }
}
