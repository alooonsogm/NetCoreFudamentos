namespace NetCoreFudamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAños = new RadioButton();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            label4 = new Label();
            label5 = new Label();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(122, 103);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(369, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(122, 155);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 200);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 4;
            label3.Text = "Incremento";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(122, 196);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 5;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(122, 221);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 6;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAños
            // 
            rdbAños.AutoSize = true;
            rdbAños.Location = new Point(122, 246);
            rdbAños.Name = "rdbAños";
            rdbAños.Size = new Size(52, 19);
            rdbAños.TabIndex = 7;
            rdbAños.TabStop = true;
            rdbAños.Text = "Años";
            rdbAños.UseVisualStyleBackColor = true;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(422, 196);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 8;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(348, 225);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(120, 34);
            btnIncremento.TabIndex = 9;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 299);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 11;
            label5.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(122, 317);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(369, 23);
            txtFechaFinal.TabIndex = 12;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFechaFinal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnIncremento);
            Controls.Add(txtIncremento);
            Controls.Add(rdbAños);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private Label label2;
        private Label label3;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAños;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private Label label4;
        private Label label5;
        private TextBox txtFechaFinal;
    }
}