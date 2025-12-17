namespace NetCoreFudamentos
{
    partial class Form14Metodos
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
            lblResultado = new Label();
            txtNumero = new TextBox();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblRaton = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(21, 99);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(21, 50);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(159, 23);
            txtNumero.TabIndex = 2;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(21, 135);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(139, 40);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(21, 194);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(139, 41);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(21, 251);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(139, 39);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.Lime;
            lblRaton.Location = new Point(320, 135);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(284, 155);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 41);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 7;
            label2.Text = "Solo numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 84);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 8;
            label3.Text = "Solo letras";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(436, 38);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(168, 23);
            txtSoloNumeros.TabIndex = 9;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(436, 81);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(168, 23);
            txtSoloLetras.TabIndex = 10;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(txtNumero);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtNumero;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblRaton;
        private Label label2;
        private Label label3;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
    }
}