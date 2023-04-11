using Sumador_biblio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador(2);    
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador(5);

            int entero = (int)sumador;
            Console.WriteLine(s1.Sumar(5, 5));

            Console.WriteLine(s2.Sumar("Hola", "Mundo"));

            Console.WriteLine(s1 + s2);

            Console.WriteLine(s1 | s2);

            Console.WriteLine($"Cantidad de sumas: {entero}");
        }
    }
}