using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> textos;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            textos = new List<TextBox>();
            foreach (Control boton in Controls)
            {
                if(boton is Button)
                {
                    boton.Click += HacerTabla;
                } else if(boton is TextBox)
                {
                    textos.Add((TextBox)boton);
                }
            }
            textos.Reverse();
        }

        private void HacerTabla(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int valor = int.Parse(botonPulsado.Text);
            int mult = 1;

            foreach (TextBox txt in textos)
            {
                if (txt is TextBox)
                {
                    txt.Text = (valor * mult).ToString();
                    mult++;
                }
            }
        }
    }
}
