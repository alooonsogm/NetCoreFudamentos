namespace NetCoreFudamentos
{
    partial class Form02ColoresPosicion
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            label2 = new Label();
            btnPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnColor = new Button();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Posicion X";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(119, 95);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(149, 23);
            txtPosicionX.TabIndex = 1;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(119, 162);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(149, 23);
            txtPosicionY.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 144);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 3;
            label2.Text = "Posicion Y";
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(133, 207);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(121, 28);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(500, 64);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(504, 132);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 207);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // btnColor
            // 
            btnColor.Location = new Point(513, 274);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(124, 35);
            btnColor.TabIndex = 8;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(500, 88);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(148, 23);
            txtRojo.TabIndex = 9;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(504, 155);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(144, 23);
            txtVerde.TabIndex = 10;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(504, 234);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(144, 23);
            txtAzul.TabIndex = 11;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(btnColor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnPosicion);
            Controls.Add(label2);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Label label2;
        private Button btnPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnColor;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
    }
}