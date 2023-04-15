using System.Text;

namespace Primavera_biblio
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        public DateTime SetFechaNacimiento()  
        {
            return this.fechaDeNacimiento;
        } 

        public string GetNombre() 
        {
            return nombre;
        }
        public string GetFechaDeNacimiento()
        {
            return fechaDeNacimiento.ToShortDateString();
        }
        public string GetDni() 
        {
            return dni;
        }
       
        private int CalcularEdad() 
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - fechaDeNacimiento.Year;
            if (fechaDeNacimiento > hoy.AddYears(-edad))  
            {
                edad--;
            }
            return edad;
        }
        public string EsMayorDeEdad()
        {
       
            if (CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
        public string Mostrar() 
        {
            StringBuilder sp = new StringBuilder();
            sp.AppendLine($"Nombre: {this.nombre}");
            sp.AppendLine($"Edad Actual: {CalcularEdad()}");
            sp.AppendLine($"DNI : {this.dni}");
            return sp.ToString();
        }
    }
}