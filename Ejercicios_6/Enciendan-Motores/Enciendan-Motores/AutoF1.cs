using System.Text;

namespace Enciendan_Motores
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public short Combustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnComepentecia
        {
            get 
            {
                return this.enCompetencia; 
            }
            set 
            { 
                this.enCompetencia = value; 
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a1.escuderia);
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {this.numero.ToString()}");
            sb.AppendLine($"Escuderia: {this.escuderia.ToString()}");
            sb.AppendLine($"Cantidad de combustible: {this.Combustible}");
            sb.AppendLine($"En competencia: {this.EnComepentecia}");
            sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes.ToString()}");
            return sb.ToString();
        }
    
    }
}
