
using Universal_biblio;

namespace Universal_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El ejemplo universal";

            Estudiante A1 = new Estudiante("Ezequiel", "Moran", "1234");
            Estudiante A2 = new Estudiante("Lorenzo", "Lama", "1000");
            Estudiante A3 = new Estudiante("Nicolas", "Tagliafico", "1111");

            A1.SetNotaPrimerParcial(6);
            A1.SetNotaSegundoParcial(5);

            A2.SetNotaPrimerParcial(2);
            A2.SetNotaSegundoParcial(3);

            A3.SetNotaPrimerParcial(7);
            A3.SetNotaSegundoParcial(9);

            Console.WriteLine(A1.Mostrar());
            Console.WriteLine(A2.Mostrar());
            Console.WriteLine(A3.Mostrar());
        }
    }
}