using Invento_argentino;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boliAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boliRed = new Boligrafo(ConsoleColor.Red, 50);

            Console.WriteLine($"Bolígrafo azul - Tinta: {boliAzul.GetTinta()}, Color: {boliAzul.GetColor()}");
            Console.WriteLine($"Bolígrafo rojo - Tinta: {boliRed.GetTinta()}, Color: {boliRed.GetColor()}");

            Console.WriteLine("-----------------------------------------------------------------");
            boliAzul.Pintar(10, "*");
            Console.WriteLine($"Bolígrafo azul - Tinta: {boliAzul.GetTinta()}, Color: {boliAzul.GetColor()}");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            boliRed.Pintar(30, "*");
            Console.WriteLine($"Bolígrafo rojo - Tinta: {boliRed.GetTinta()}, Color: {boliRed.GetColor()}");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------------------------------");
            boliAzul.Recargar();
            Console.WriteLine($"Bolígrafo azul - Tinta: {boliAzul.GetTinta()}, Color: {boliAzul.GetColor()}");

            Console.WriteLine("-----------------------------------------------------------------");
            boliAzul.Recargar();
            Console.WriteLine($"Bolígrafo Roja - Tinta: {boliRed.GetTinta()}, Color: {boliRed.GetColor()}");
        }
    }
}