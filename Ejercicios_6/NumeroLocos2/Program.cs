using System.Collections;
using System.Text;

namespace NumeroLocos2
{
    internal class Program
    {
        static List<int> list;
        static Stack<int> pila;
        static Queue<int> queue;
        static void Main(string[] args)
        {
            
            GenerarNumerosAleatoriosLista();
            Console.WriteLine("*** LIST ****");
            Console.WriteLine("Numero tal como fueron ingresado: ");
            foreach (int num in list)
            {
                Console.WriteLine($"El numero es: {num}");
            }      

            Console.WriteLine("\n");
            Console.WriteLine("Lista Positivos:");
            list.Sort((num, b) => b.CompareTo(num));
            foreach (int num in list)
            {
                if (num > 0)
                {
                    Console.Write($"\nDecreciente {num}");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Lita Negativo:");
            list.Sort((num, b) => b.CompareTo(num));
            foreach (int num in list)
            {
                if (num < 0)
                {
                    Console.Write($"\nCrecientes {num}");
                }
            }
            //

            Console.WriteLine("\n");
            Console.WriteLine("=========================================");
            Console.Write("LISTA ORIGINAL DE STACK(PILA)");
            Console.WriteLine();
            GenerarNumerosAleatoriosPila();
           
            foreach (int num in pila)
            {
                Console.WriteLine($"El numero es: {num}");
            }
            
            Stack<int> sortedStack = new Stack<int>();

            while (pila.Count > 0)
            {
                int temp = (int)pila.Pop();
                while (sortedStack.Count > 0 && (int)sortedStack.Peek() > temp)
                {
                    pila.Push(sortedStack.Pop());
                }
                sortedStack.Push(temp);
            }
            Console.WriteLine();
            Console.Write("*** PILA POSIIVOS *** ");
           
            foreach (var item in sortedStack)
            {
                if (item > 0) 
                {
                    Console.Write($"\nPositivos: {item}");
                }
            }
            Console.WriteLine("\n");
            Console.Write("*** PILA NEGATIVOS *** ");
            foreach (var item in sortedStack)
            {
                if (item < 0)
                {
                    Console.Write($"\nNegativos: {item}");
                }
            }
          
            //
            Console.Write("\n\n");
            Console.WriteLine("=========================================");
            Console.Write("LISTA ORIGINAL DE QUEUE(COLA)");
            Console.Write("\n");

            GenerarNumerosAleatoriosCola();
            foreach (int num in queue)
            {
                Console.WriteLine($"El numero es: {num}");
            }

            ArrayList arrayList = new ArrayList();

            while (queue.Count > 0) 
            {
                arrayList.Add(queue.Dequeue());
            }

            arrayList.Sort();

            Queue<int> colaAux = new Queue<int>();

            foreach (int item in arrayList) 
            {
                colaAux.Enqueue(item);
            }
            Console.WriteLine();
            Console.Write("*** COLA POSITIVOS *** ");
            foreach (var item in colaAux)
            {
                if (item > 0) 
                {

                    Console.Write($"\nPositivos: {item}");

                }
            }
            Console.WriteLine("\n");
            Console.Write("*** COLA NEGATIVOS *** ");
            foreach (var item in colaAux)
            {
                if (item < 0)
                {

                    Console.Write($"\nPositivos: {item}");

                }
            }
        }
        static int GenerarNumerosRandom(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        static void GenerarNumerosAleatoriosLista() 
        {
            list = new List<int>();
            while (list.Count < 20)
            {
                int num = 0;
                do
                {
                    num = GenerarNumerosRandom(-100, 100);
                } while (num == 0 || list.Contains(num));
                list.Add(num);
            }
        }
        static void GenerarNumerosAleatoriosPila()
        {
            pila = new Stack<int>();
            while (pila.Count < 20)
            {
                int num = 0;
                do
                {
                    num = GenerarNumerosRandom(-100, 100);
                } while (num == 0 || pila.Contains(num));
                pila.Push(num);
            }
        }
        static void GenerarNumerosAleatoriosCola()
        {
            queue = new Queue<int>();
            while (queue.Count < 20)
            {
                int num = 0;
                do
                {
                    num = GenerarNumerosRandom(-100, 100);
                } while (num == 0 || queue.Contains(num));
                queue.Enqueue(num);
            }
        }

    }
  
}

