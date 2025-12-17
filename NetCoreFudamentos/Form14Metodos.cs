using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        //Recibimos un wrapper por valor
        int GetDobleValor(int numero)
        {
            return numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int result = this.GetDobleValor(num);
            this.lblResultado.Text = result.ToString();
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGoldenrodYellow;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            //Con ref, las dos variables apuntan al mismo espacio de memoria
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tenemos una enumeracion llamada keys que nos permite acceder a los codigos del teclado
            //Debemos saber el codigo ASCII de la tecla de borrar.
            char teclaBorrar = (char)Keys.Back;
            //Existe una forma de saber si un char es un numero
            if(char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                //Indica si nos hacemos cargo del evento key, por lo que no dibuja.
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
