using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int año = int.Parse(this.txtAño.Text);

            if (mes == 1)
            {
                mes = 13;
                año = año - 1;
            }

            if (mes == 2)
            {
                mes = 14;
                año = año - 1;
            }

            int ope1 = ((mes + 1) * 3) / 5;
            int ope2 = año / 4;
            int ope3 = año / 100;
            int ope4 = año / 400;

            int ope5 = dia + (mes * 2) + año + ope1 + ope2 - ope3 + ope4 + 2;
            int ope6 = ope5 / 7;
            int result = ope5 - (ope6 * 7);
            string elDia = "";
            if (result == 0)
            {
                elDia = "Sabado";
            } else if (result == 1) 
            {
                elDia = "Domingo";
            } else if (result == 2)
            {
                elDia = "Lunes";
            } else if (result == 3)
            {
                elDia = "Martes";
            } else if (result == 4)
            {
                elDia = "Miercoles";
            } else if (result == 5)
            {
                elDia = "Jueves";
            } else if (result == 6)
            {
                elDia = "Viernes";
            }
            this.lblDia.Text = "El dia de la semana es " + elDia;
        }
    }
}
