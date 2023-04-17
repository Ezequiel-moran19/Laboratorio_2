using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_101
{
    public partial class Saludo : Form
    {
        public Saludo(string titulo, string mensaje)
        {
            InitializeComponent();
            label1.Text = titulo;
            label2.Text = mensaje;
        }

        private void Saludo_Load(object sender, EventArgs e)
        {

        }
    }
}
