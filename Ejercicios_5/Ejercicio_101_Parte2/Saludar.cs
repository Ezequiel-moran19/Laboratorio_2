using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_101_Parte2
{
    public partial class Saludar : Form
    {
        public Saludar(string titulo, string mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }

        private void Saludar_Load(object sender, EventArgs e)
        {

        }
    }
}
