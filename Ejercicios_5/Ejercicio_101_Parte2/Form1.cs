using System.Text;

namespace Ejercicio_101_Parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string titulo = "¡Hola , Windows Forms!";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cmbMaterias.SelectedItem}";

            if (Validar()) 
            {
                Saludar saludo = new Saludar(titulo, mensaje);
                saludo.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMaterias.Items.Add("Programacion 2");
            cmbMaterias.Items.Add("Laboratorio 3");
            cmbMaterias.Items.Add("Ingles");
            cmbMaterias.Items.Add("Metodologia de la investigacion");
            cmbMaterias.SelectedIndex = 0;
        }
        private bool Validar()
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}