using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enciendan_Motores
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        public Competencia() 
        {
            this.competidores = new List<AutoF1>();
        }

        public  Competencia(short cantidadVueltas, short cantidadCompetidores)
            :this() 
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool aux = false;
            if (c.competidores.Count > 0) 
            {
                foreach (AutoF1 auto in c.competidores) 
                {
                    if (auto == a) 
                    {
                        aux = true;
                        break;
                    }
                }
            }
            return aux;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random combustibleRd = new Random();
            bool rtn = false;
            //Evaluaos que la competencia aun tenga capacidad pra aceptar competidores y si el competidor a agregar no existe
            if (c.competidores.Count < c.cantidadCompetidores && c!=a) 
            {
                a.EnComepentecia = true;
                a.VueltasRestantes = c.cantidadVueltas;
                a.Combustible = (short)combustibleRd.Next(15, 100);
                c.competidores.Add(a);
                rtn = true;
            }
            return rtn; 
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool rtn = false;
            //Verificaos si el auto pertenece a la competencia y lo retiramos
            if (c == a)
            {
                c.competidores.Remove(a);
                rtn = true;
            }
            return rtn;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad vueltas en la competencia: {this.cantidadVueltas.ToString()}");
            sb.AppendLine($"Cantidad competidores: {this.cantidadCompetidores.ToString()}");
            foreach (AutoF1 auto in this.competidores) 
            {
                sb.AppendLine($"Competidores {auto.MostrarDatos()}");
            }
            return sb.ToString();
        }
    }

}
/*
La sobrecarga del operador + agregará un competidor si es que aún hay espacio
(validar con cantidadCompetidores) y el competidor no forma parte de la lista
(== entre Competencia y AutoF1).
Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero,
la cantidad de vueltasRestantes será igual a la cantidadVueltas de 
Competencia y se le asignará un número aleatorio entre 
15 y 100 a cantidadCombustible.
 */