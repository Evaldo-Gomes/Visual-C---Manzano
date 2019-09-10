using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap6_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];

            int i;

            //Entrada de dados

            for (i = 0; i <= 9; i++)
            {
                Console.Write("Media do {0}° aluno: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            //Processamento par ou impar

            for (i = 0; i <= 9; i++)
                if (i % 2 == 0)
                    B[i] = A[i] * 5;
                else
                    B[i] = A[i] + 5;
            Console.WriteLine();

            //Apresentação dos arranjos

            for (i = 0; i <= 9; i++)
            {
                Console.Write("A[{0}] = {1}  ->  ", i + 1, A[i]);
                Console.Write("B[{0}] = {1,5}", i + 1, B[i]);   //alinhamento à direita
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();

        }
    }
}
