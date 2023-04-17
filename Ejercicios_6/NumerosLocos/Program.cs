namespace NumerosLocos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random random = new Random();

            while (numeros.Count < 20)
            {
                int num = 0;
                do
                {
                    num = random.Next(-100, 100);
                } while (num == 0 || numeros.Contains(num));
                numeros.Add(num);
            }

            Console.WriteLine("Numero tal como fueron ingresado: ");
            foreach (int num in numeros)
            {
                Console.WriteLine($"El numero es: {num}");
            }
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Positivos ordenados en forma decreciente:");
            numeros.Sort((num, b) => b.CompareTo(num));
            foreach (int num in numeros)
            {
                if (num > 0)
                {
                    Console.Write($"\nDecreciente {num}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("Negativos ordenados en forma creciente:");
            numeros.Sort((num, b) => b.CompareTo(num));
            foreach (int num in numeros)
            {
                if (num < 0)
                {
                    Console.Write($"\nCrecientes {num}");
                }
            }

        }
    }
}