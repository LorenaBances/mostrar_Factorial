using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mostrar_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Mostrar números pares");
                Console.WriteLine("2. Mostrar números impares");
                Console.WriteLine("3. Calcular el factorial");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese el número de opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarNumerosPares();
                        break;
                    case 2:
                        MostrarNumerosImpares();
                        break;
                    case 3:
                        CalcularFactorial();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void MostrarNumerosPares()
        {
            Console.WriteLine("Lista de números pares:");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }


        static void MostrarNumerosImpares()
        {
            Console.WriteLine("Lista de números impares:");
            for (int i = 1; i <= 19; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static void CalcularFactorial()
        {
            Console.Write("Ingrese un número para calcular su factorial: ");
            int numero = int.Parse(Console.ReadLine());

            long factorial = CalcularFactorialRecursivo(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }

        static long CalcularFactorialRecursivo(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("El factorial no está definido para números negativos.");
            }

            if (n == 0 || n == 1)
            {
                return 1;
            }

            return n * CalcularFactorialRecursivo(n - 1);
        }
       
    }
}
