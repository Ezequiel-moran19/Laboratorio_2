using Billetes;
namespace Vista_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Peso billetePeso = (Peso)billeteEuro;
            Console.WriteLine(billetePeso.GetCantidad());

            Dolar billeteDolar = 1.17;
            Peso billetePeso2 = (Peso)billeteDolar;
            Console.WriteLine(billetePeso2.GetCantidad());

            Peso billeteP3 = 102;
            Dolar BilleteD = (Dolar)billeteP3;
            Console.WriteLine(BilleteD.GetCantidad());

        }
    }
}