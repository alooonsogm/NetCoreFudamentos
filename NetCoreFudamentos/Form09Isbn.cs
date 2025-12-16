using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnIsbn_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;

            if(isbn.Length != 10)
            {
                this.lblIsbn.Text = "ISBN debe contener 10 caracteres.";
            } else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int ayuda = numero * (i + 1);
                    suma += ayuda;
                }

                if (suma % 11 == 0)
                {
                    this.lblIsbn.Text = "ISBN correcto.";
                }
                else
                {
                    this.lblIsbn.Text = "ISBN no correcto.";
                }
            }
        }
    }
}
