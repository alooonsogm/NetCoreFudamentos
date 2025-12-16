using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.lstNumeros.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                this.lstNumeros.Items.Add(random.Next(1, 100));
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int numero in this.lstNumeros.Items)
            {
                sumaTotal += numero;
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            this.txtSumar.Text = sumaTotal.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
