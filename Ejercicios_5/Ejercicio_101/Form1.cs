namespace Ejercicio_101
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
            string mensaje = $"Soy {textBox1.Text} {textBox2.Text}.";

            Saludo saludo = new Saludo(titulo, mensaje);
            saludo.ShowDialog();
        }
    }
}