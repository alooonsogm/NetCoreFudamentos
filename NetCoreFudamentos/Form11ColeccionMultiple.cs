using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //La lista tendrá seleccion multiple
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtElemento.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //Vamos a recorrer la coleccion de items seleccionados
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Quiero eliminar los elementos seleccionados
            //Para las acciones sobre las colecciones siempre con bucles contador
            //Voy a utilizar el metodo removeAt por lo que recorremos
            //la coleccion selectedIndices, se debe hacer a la inversa para
            //que no afecte a los indices cuando se elime el primer selecionado.
            for (int i = this.lstElementos.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                //Eliminamos de la coleccion
                this.lstElementos.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
