using ConversorBinarioRecargado;
namespace Vista_Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario nB =  (NumeroBinario)"100";
            NumeroDecimal nD = (NumeroDecimal)4;

            Console.WriteLine($"El numero binario es: {nB.Numero}, sumado con el decimal de: {nD + nB}");
            Console.WriteLine($"El numero Decimal es: {nD.Numero}, sumado con el binario de: {nB + nD}");
        }
    }
}