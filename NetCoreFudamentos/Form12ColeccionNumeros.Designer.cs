namespace NetCoreFudamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnDatos = new Button();
            label2 = new Label();
            txtSumar = new TextBox();
            txtPares = new TextBox();
            label3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(81, 90);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(141, 184);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(320, 90);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(143, 33);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar numeros";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(320, 129);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(143, 29);
            btnDatos.TabIndex = 3;
            btnDatos.Text = "Mostrar datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 178);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 4;
            label2.Text = "Sumar:";
            // 
            // txtSumar
            // 
            txtSumar.Location = new Point(363, 175);
            txtSumar.Name = "txtSumar";
            txtSumar.Size = new Size(100, 23);
            txtSumar.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(363, 206);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 209);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Pares:";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(363, 239);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 242);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 8;
            label4.Text = "Impares:";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSumar);
            Controls.Add(label2);
            Controls.Add(btnDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnDatos;
        private Label label2;
        private TextBox txtSumar;
        private TextBox txtPares;
        private Label label3;
        private TextBox txtImpares;
        private Label label4;
    }
}