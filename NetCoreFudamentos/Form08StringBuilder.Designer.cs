namespace NetCoreFudamentos
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnStringBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 61);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Copie texto para trabajar:";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(94, 89);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(469, 210);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(94, 314);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(61, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnString
            // 
            btnString.Location = new Point(161, 351);
            btnString.Name = "btnString";
            btnString.Size = new Size(151, 34);
            btnString.TabIndex = 3;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnStringBuilder
            // 
            btnStringBuilder.Location = new Point(366, 351);
            btnStringBuilder.Name = "btnStringBuilder";
            btnStringBuilder.Size = new Size(143, 34);
            btnStringBuilder.TabIndex = 4;
            btnStringBuilder.Text = "Invertir StringBuilder";
            btnStringBuilder.UseVisualStyleBackColor = true;
            btnStringBuilder.Click += btnStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStringBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Label lblTiempo;
        private Button btnString;
        private Button btnStringBuilder;
    }
}