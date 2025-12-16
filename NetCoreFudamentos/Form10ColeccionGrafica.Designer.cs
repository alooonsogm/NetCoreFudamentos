namespace NetCoreFudamentos
{
    partial class Form10ColeccionGrafica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lstElementos = new ListBox();
            label2 = new Label();
            txtElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(114, 94);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 124);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 67);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo elemento:";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(364, 94);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(246, 23);
            txtElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(364, 123);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(246, 27);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(364, 156);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(246, 25);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(364, 187);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(246, 26);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(114, 221);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(44, 15);
            lblItem.TabIndex = 7;
            lblItem.Text = "lblItem";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(114, 253);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(48, 15);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "lblIndex";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblItem;
        private Label lblIndex;
    }
}