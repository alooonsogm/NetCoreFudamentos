using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFudamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            bool ayuda = false;

            foreach (string elProducto in this.lstTienda.Items)
            {
                if (elProducto == producto)
                {
                    ayuda = true;
                }
            }

            if (ayuda == true)
            {
                MessageBox.Show("El producto ya existe en la lista");
            }
            else
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.Focus();
                this.txtProducto.SelectAll();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            foreach (string elProducto in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(elProducto);
            }

            for (int i = this.lstTienda.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string elProducto in this.lstTienda.Items)
            {
                this.lstAlmacen.Items.Add(elProducto);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            //Obtener el índice actual
            int indiceActual = this.lstAlmacen.SelectedIndex;

            //Verificar que no sea el primer elemento (no se puede subir más)
            if (indiceActual > 0)
            {
                // 1. Obtener el texto del producto
                string producto = this.lstAlmacen.SelectedItem.ToString();

                // 2. Eliminar de la posición actual
                this.lstAlmacen.Items.RemoveAt(indiceActual);

                // 3. Insertar en la posición superior (indiceActual - 1)
                this.lstAlmacen.Items.Insert(indiceActual - 1, producto);

                // 4. Mantener la selección en el nuevo lugar
                this.lstAlmacen.SelectedIndex = indiceActual - 1;
            }
            else
            {
                MessageBox.Show("El producto seleccionado ya se encuentra en la cima de la lista.");
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
         {
            //Obtener el índice actual y el total de elementos
            int indiceActual = this.lstAlmacen.SelectedIndex;

            //Verificar que no sea el último elemento (no se puede bajar más)
            if (indiceActual < this.lstAlmacen.Items.Count - 1)
            {
                // 1. Obtener el texto del producto
                string producto = this.lstAlmacen.SelectedItem.ToString();

                // 2. Eliminar de la posición actual
                this.lstAlmacen.Items.RemoveAt(indiceActual);

                // 3. Insertar en la posición inferior (indiceActual + 1)
                this.lstAlmacen.Items.Insert(indiceActual + 1, producto);

                // 4. Mantener la selección en el nuevo lugar
                this.lstAlmacen.SelectedIndex = indiceActual + 1;
            }
            else
            {
                MessageBox.Show("El producto seleccionado ya se encuentra al final de la lista.");
            }
        }
    }
}
