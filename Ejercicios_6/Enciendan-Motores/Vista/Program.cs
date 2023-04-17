using Enciendan_Motores;
namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 5);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++) 
            {
                autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                if ((formulaUno + autos[i]) == true)
                {
                    Console.WriteLine($"Se agrego el siguiente auto a la competencia: {autos[i].MostrarDatos()}");
                }
                else
                {
                    Console.WriteLine($"No se agrego ya que la competencia esta completa: {autos[i].MostrarDatos()}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("<---------------------------------------------------------------------------------------->");
            Console.WriteLine(formulaUno.MostrarDatos());
        }
    }
}