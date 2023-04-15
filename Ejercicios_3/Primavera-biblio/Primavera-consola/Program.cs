using Primavera_biblio;

namespace Primavera_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona1 = new Persona("Juan Perez", new DateTime(1990, 5, 15), "12345678");
            Persona persona2 = new Persona("Maria Gomez", new DateTime(2005, 10, 30), "23456789");
            Persona persona3 = new Persona("Pedro Rodriguez", new DateTime(1985, 3, 22), "34567890");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());
            
            Console.WriteLine("\nMayores de edad:");
            if (persona1.EsMayorDeEdad() == "Es mayor de edad")
            {
                Console.WriteLine(persona1.GetNombre());
            }
            if (persona2.EsMayorDeEdad() == "Es mayor de edad")
            {
                Console.WriteLine(persona2.GetNombre());
            }
            if (persona3.EsMayorDeEdad() == "Es mayor de edad")
            {
                Console.WriteLine(persona3.GetNombre());
            }
                    
            Console.WriteLine("\nMenores de edad:");
            if (persona1.EsMayorDeEdad() == "Es menor")
            {
                Console.WriteLine(persona1.GetNombre());
            }
            if (persona2.EsMayorDeEdad() == "Es menor")
            {
                Console.WriteLine(persona2.GetNombre());
            }
            if (persona3.EsMayorDeEdad() == "Es menor")
            {
                Console.WriteLine(persona3.GetNombre());
            } 
        }
    }
}