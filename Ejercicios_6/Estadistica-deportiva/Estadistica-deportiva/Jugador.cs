using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_deportiva
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int tatalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.tatalGoles = 0;
        }
        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int tatalGoles, int totalPartidos)
            :this(dni,nombre)
        {
            this.tatalGoles = tatalGoles;
            this.partidosJugados = totalPartidos; 
        }

        /*
        public float GetPromedioGoles() 
        {
            return  (float)this.tatalGoles / this.partidosJugados;
        }
        */
      
        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre {this.nombre}");
            sb.AppendLine($"DNI {this.dni.ToString()}");
            sb.AppendLine($"Total partidos jugados {this.partidosJugados.ToString()}");
            sb.AppendLine($"Total goles {this.tatalGoles.ToString()}");
            sb.AppendLine($"Promedio de goles {this.PromedioGoles.ToString()}");
            return sb.ToString(); 
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return j1.dni == j2.dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        //Agregado del Ejercicio C01 - Jugadores encapsulados 
        public int PartidosJugados { get => partidosJugados; }
        public float PromedioGoles 
        {
            get
            {
                return (float)this.tatalGoles / this.partidosJugados;
            }
        }
        public int TatalGoles { get => tatalGoles; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        

      
    }
}
