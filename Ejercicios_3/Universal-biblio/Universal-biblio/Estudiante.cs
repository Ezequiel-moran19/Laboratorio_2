using System.Text;

namespace Universal_biblio
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        public double CalularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }
            return -1;
        }
        private float CalularPromedio()
        {
            return (this.notaPrimerParcial + (float)this.notaSegundoParcial) / 2;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = CalularNotaFinal();
            sb.AppendLine($"Nombre: {this.nombre}, Apellido: {this.apellido}, Legajo: {this.legajo}");
            sb.AppendLine($"Primer Parcial: {this.notaPrimerParcial}, Segundo Parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalularPromedio()}");

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }
            return sb.ToString();
        }


    }
}