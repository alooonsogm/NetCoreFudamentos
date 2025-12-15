namespace NetCoreFudamentos
{
    partial class Form07SumarString
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
            label2 = new Label();
            txtNumeros = new TextBox();
            lblResultado = new Label();
            btnNumeros = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 70);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Introduzca numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(163, 97);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(192, 23);
            txtNumeros.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(163, 203);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // btnNumeros
            // 
            btnNumeros.Location = new Point(199, 142);
            btnNumeros.Name = "btnNumeros";
            btnNumeros.Size = new Size(130, 29);
            btnNumeros.TabIndex = 4;
            btnNumeros.Text = "Sumar numeros";
            btnNumeros.UseVisualStyleBackColor = true;
            btnNumeros.Click += btnNumeros_Click;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNumeros);
            Controls.Add(lblResultado);
            Controls.Add(txtNumeros);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumeros;
        private Label lblResultado;
        private Button btnNumeros;
    }
}