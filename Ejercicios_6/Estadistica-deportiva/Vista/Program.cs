using Estadistica_deportiva;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(3, "River");
            Jugador j1 = new Jugador(123, "Ezequiel", 5, 20);
            Jugador j2 = new Jugador(423, "Ian", 5, 5);
            Jugador j3 = new Jugador(553, "Nicola", 6, 4);
            Jugador j4 = new Jugador(783, "Marcos", 3, 5);

            if (equipo + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }
            else 
            {
                Console.WriteLine($"No SE AGREGO {j1.MostrarDatos()}");
            }

            if (equipo + j2)
            {
                Console.WriteLine(j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No SE AGREGO {j2.MostrarDatos()}");
            }
            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No SE AGREGO {j3.MostrarDatos()}");
            }
            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine($"No SE AGREGO {j4.MostrarDatos()}");
            }
        }
    }
}