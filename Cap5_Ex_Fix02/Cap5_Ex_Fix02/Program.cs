using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*SÉRIE DE FINONACCI EM N TERMOS*/

namespace Cap5_Ex_Fix02
{
    class Program
    {
        public static long N, Last;

        static void Main(string[] args)
        {
            Console.Title = "Calculadora Fibonacci";
            Console.WriteLine("Calculadora de séria de Fibonacci");
            Programa();
        }

        public static void Entrada()
        {
            Console.Write("Insira o comprimento da série: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public static void Saida()
        {
            Last = CalculoFibonacci(N);
            Console.WriteLine();
            Console.WriteLine("O último elemento da série é {0}.", Last);
            Console.WriteLine();
        }

        public static long CalculoFibonacci(long X)
        {
            long a = 0, b = 1, R = 0;
            for (long i = 1; i <= N; i++)
            {
                a = b;
                b = R;
                R = a + b;
                Console.WriteLine("O valor do " + i + "° membro é: {0}", R);
            }
            return R;
        }

        private static void Programa()
        {
            Entrada();
            Saida();
        }
    }
}
