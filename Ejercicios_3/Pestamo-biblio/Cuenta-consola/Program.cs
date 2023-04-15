using Pestamo_biblio;

namespace Cuenta_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Creo que necesito un prestamo";

            Cuenta c1 = new Cuenta("Eze", 2000);

            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(500.65);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(200);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(300);
            Console.WriteLine(c1.Mostrar());
            c1.Retirar(500);
            Console.WriteLine(c1.Mostrar());
            c1.Ingresar(1500);
            Console.WriteLine(c1.Mostrar());
        }
    }
}