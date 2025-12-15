using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;

            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "Falta el @";
            } else if (email.StartsWith("@") == true)
            {
                this.lblResultado.Text = "No se puede @ al principio";
            } else if (email.EndsWith("@") == true)
            {
                this.lblResultado.Text = "No se puede @ al final";
            } else if(email.IndexOf("@", email.IndexOf("@") + 1) != -1)
            {
                this.lblResultado.Text = "Existe mas de un @";
            }
            else if (email.Contains(".") == false)
            {
                this.lblResultado.Text = "Falta un .";
            }
            else if (email.IndexOf(".", email.IndexOf("@")) == -1)
            {
                this.lblResultado.Text = "Hay que poner el . despues del @";
            }
            else if (email.Substring(email.LastIndexOf(".")).Length > 4 || email.Substring(email.LastIndexOf(".")).Length < 3)
            {
                this.lblResultado.Text = "El dominio debe ser de 2 o 3 caracteres";
            }
            else
            {
                this.lblResultado.Text = "Email correcto";
            }
        }
    }
}
