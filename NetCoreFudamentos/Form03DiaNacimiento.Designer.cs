namespace NetCoreFudamentos
{
    partial class Form03DiaNacimiento
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
            label3 = new Label();
            label4 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            btnFecha = new Button();
            label5 = new Label();
            lblDia = new Label();
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
            label2.Location = new Point(72, 63);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "Dia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 100);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Mes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 143);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 3;
            label4.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(179, 63);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(179, 100);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 5;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(179, 143);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 6;
            // 
            // btnFecha
            // 
            btnFecha.Location = new Point(110, 189);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(93, 39);
            btnFecha.TabIndex = 7;
            btnFecha.Text = "Mostrar dia";
            btnFecha.UseVisualStyleBackColor = true;
            btnFecha.Click += btnFecha_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(132, 253);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(38, 15);
            lblDia.TabIndex = 9;
            lblDia.Text = "label6";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDia);
            Controls.Add(label5);
            Controls.Add(btnFecha);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form04DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Button btnFecha;
        private Label label5;
        private Label lblDia;
    }
}