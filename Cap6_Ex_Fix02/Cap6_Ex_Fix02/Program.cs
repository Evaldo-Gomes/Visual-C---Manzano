using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LEITURA DA MATRIZ A, CÁLCULO DO FATORIAL E CONSTRUÇÃO DA MATRIZ B*/


namespace Cap6_Ex_Fix02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];
            int i, j, Fat;

            for (i = 0; i <= 9; i++)
            {
                Console.Write("Insira o valor do {0} elemento: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            for (i = 0; i <= 9; i++)
            {
                if (A[i] == 1)
                {
                    Console.Write("Fatorial de A[{0}] = ", A[i]);
                    Console.WriteLine("B[{0}]", 1);
                }
                else
                {
                    Fat = A[i];
                    for (j = A[i] - 1; j >= 1; j--)
                    {
                        Fat = Fat * j;
                        B[i] = Fat;
                    }
                    Console.Write("Fatorial de A[{0}] = ", A[i]);
                    Console.WriteLine("B[{0}]", B[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }

    }
}
