namespace Estadistica_deportiva
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();   
        }
        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador i in e.jugadores)
                {
                    if (i == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}