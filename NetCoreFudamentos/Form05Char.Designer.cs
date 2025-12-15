namespace NetCoreFudamentos
{
    partial class Form05Char
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
            Letras = new Label();
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            label1 = new Label();
            txtSimbolos = new TextBox();
            label2 = new Label();
            txtPuntuacion = new TextBox();
            label3 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // Letras
            // 
            Letras.AutoSize = true;
            Letras.Location = new Point(60, 45);
            Letras.Name = "Letras";
            Letras.Size = new Size(38, 15);
            Letras.TabIndex = 0;
            Letras.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(60, 63);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(179, 108);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(356, 63);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(179, 108);
            txtNumeros.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 45);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 2;
            label1.Text = "Numeros";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(60, 219);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(179, 108);
            txtSimbolos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 201);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Simbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(356, 219);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(179, 108);
            txtPuntuacion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(356, 201);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Puntuacion";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(242, 349);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(120, 42);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtSimbolos);
            Controls.Add(label2);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Controls.Add(txtLetras);
            Controls.Add(Letras);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Letras;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private Label label1;
        private TextBox txtSimbolos;
        private Label label2;
        private TextBox txtPuntuacion;
        private Label label3;
        private Button btnRun;
    }
}