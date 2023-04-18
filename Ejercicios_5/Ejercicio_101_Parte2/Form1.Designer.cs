namespace Ejercicio_101_Parte2
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
            lblNombre = new Label();
            lblMateria = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cmbMaterias = new ComboBox();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(117, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(117, 133);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(97, 15);
            lblMateria.TabIndex = 1;
            lblMateria.Text = "Materia favorita";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(251, 57);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Ingrese nombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(251, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Ingrese Apellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(117, 151);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(234, 23);
            cmbMaterias.TabIndex = 5;
            // 
            // btnSaludo
            // 
            btnSaludo.BackColor = SystemColors.ActiveCaption;
            btnSaludo.Location = new Point(251, 191);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(100, 23);
            btnSaludo.TabIndex = 6;
            btnSaludo.Text = "Saludo";
            btnSaludo.UseVisualStyleBackColor = false;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 331);
            Controls.Add(btnSaludo);
            Controls.Add(cmbMaterias);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblMateria);
            Controls.Add(lblNombre);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblMateria;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cmbMaterias;
        private Button btnSaludo;
    }
}