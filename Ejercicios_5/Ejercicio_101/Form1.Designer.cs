namespace Ejercicio_101
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new Label();
            txtApellido = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.AutoSize = true;
            txtNombre.CausesValidation = false;
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(131, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(53, 15);
            txtNombre.TabIndex = 0;
            txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.AutoSize = true;
            txtApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(131, 127);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(52, 15);
            txtApellido.TabIndex = 1;
            txtApellido.Text = "Apellido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 78);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 145);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Apellido";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(131, 196);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(75, 23);
            btnSaludo.TabIndex = 4;
            btnSaludo.Text = "Saludo";
            btnSaludo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaludo);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNombre;
        private Label txtApellido;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSaludo;
    }
}