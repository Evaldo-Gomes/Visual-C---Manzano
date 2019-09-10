using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ARRANJOS - LEITURA DE 5 VALORES INTEIROS, APRESENTAÇÃO EM ORDEM CRESCENTE*/

namespace Cap6_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[5];
            int i, j, X;

            //Entrada de dados

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Entre com um valor para A[{0}]: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            //Processamento + ordenação

            for (i = 0; i <= 4; i++)
            {
                for(j = i + 1; j <= 4; j++)
                {
                    if (A[i] > A[j])
                    {
                        X = A[i];
                        A[i] = A[j];
                        A[j] = X;
                    }
                }
            }
            Console.WriteLine();

            //Apresentação dos arranjos

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("A[{0}] = {1,4}", i, A[i]);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para continuar...");
         }
    }
}
