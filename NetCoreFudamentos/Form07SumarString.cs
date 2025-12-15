using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnNumeros_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumeros.Text;
            int suma = 0;
            //Recorremos todo el contenido de textoNumeros
            for(int i = 0; i < textoNumeros.Length; i++)
            {
                //Recuperamos cada caracter del texto
                char caracter = textoNumeros[i];
                //Convertimos cada caracter a numero
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma de " +  textoNumeros + " es " + suma;
        }
    }
}
