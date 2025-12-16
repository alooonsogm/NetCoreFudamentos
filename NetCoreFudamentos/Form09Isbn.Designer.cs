namespace NetCoreFudamentos
{
    partial class Form09Isbn
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
            txtIsbn = new TextBox();
            btnIsbn = new Button();
            lblIsbn = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 69);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un ISBN:";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(102, 87);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(263, 23);
            txtIsbn.TabIndex = 1;
            // 
            // btnIsbn
            // 
            btnIsbn.Location = new Point(102, 116);
            btnIsbn.Name = "btnIsbn";
            btnIsbn.Size = new Size(263, 30);
            btnIsbn.TabIndex = 2;
            btnIsbn.Text = "Validar ISBN";
            btnIsbn.UseVisualStyleBackColor = true;
            btnIsbn.Click += btnIsbn_Click;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(102, 167);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(38, 15);
            lblIsbn.TabIndex = 3;
            lblIsbn.Text = "label2";
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIsbn);
            Controls.Add(btnIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsbn;
        private Button btnIsbn;
        private Label lblIsbn;
    }
}