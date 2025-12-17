using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //Creamos una coleccion generica
            List<Button> botones = new List<Button>();
            //Detecta automaticamente los elementos
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones[0].BackColor = Color.Red;


            //Vamos a crear una coleccion no tipada.
            ArrayList coleccion = new ArrayList();
            coleccion.Add(button1);
            coleccion.Add(button2);
            coleccion.Add(button3);
            //Si deseamos acceder a un objeto y modificar alguna caracteristica, necesitamos realizar casting.
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            //Podemos realizar casting con for each
            foreach(Button boton in coleccion)
            {
                boton.BackColor = Color.LightCoral;
            }
            //Y si añadimos otro control que no sea un button??
            coleccion.Add(textBox1);
            //Nos abstraemos para el casting en todos los objetos, usando Control.
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
                //Cuando tenemos multiples objetos de diferentes clases, nos podemos abstraer en el recorrido,
                //pero a lo mejor necesitamos alguna caracteristica especial de cada uno.
                //Una caja tiene un metodo llamado Paste(), y si lo usamos aqui sin un if y casting no funcionaria.
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }


            this.button1.Click += MetodoDelegado;
        }

        void MetodoDelegado(object sender, EventArgs e)
        {
            
        }
    }
}
