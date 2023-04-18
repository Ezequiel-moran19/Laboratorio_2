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

            Saludar saludo = new Saludar(titulo, mensaje);
            saludo.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMaterias.Items.Add("Programacion");
            cmbMaterias.Items.Add("Laboratorio");
            cmbMaterias.Items.Add("Ingles");
            cmbMaterias.Items.Add("Metodologia de la investigacion");
            cmbMaterias.SelectedIndex = 0;
        }
    }
}