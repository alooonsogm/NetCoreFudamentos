using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posx = int.Parse(this.txtPosicionX.Text);
            int posy = int.Parse(this.txtPosicionY.Text);
            this.btnPosicion.Location = new Point(posx, posy);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int azul = int.Parse(this.txtAzul.Text);
            int verde = int.Parse(this.txtVerde.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
