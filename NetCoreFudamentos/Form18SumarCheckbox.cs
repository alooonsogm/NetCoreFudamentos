using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();
            foreach (CheckBox box in this.panel1.Controls)
            {
                this.checkboxes.Add(box);
                box.CheckedChanged += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            int suma = 0;
            foreach(CheckBox box in this.checkboxes)
            {
                if(box.Checked == true)
                {
                    suma += int.Parse(box.Text);
                }
            }
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox box in this.checkboxes)
            {
                int aleat = random.Next(1, 50);
                box.Text = aleat.ToString();
            }
        }
    }
}
