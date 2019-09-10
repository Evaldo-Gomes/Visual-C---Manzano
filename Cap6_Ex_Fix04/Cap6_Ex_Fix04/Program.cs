using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LER MATRIZ A[8] E B[8], APRESENTAR MATRIZ C[16]*/

namespace Cap6_Ex_Fix03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[] A = new int[8];
            int[] B = new int[8];
            int[] C = new int[16];

            for (i = 0; i <= 7; i++)
            {
                Console.Write("Entre com o A[{0}] valor: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= 7; i++)
            {
                C[i] = A[i];
            }

            Console.WriteLine();
            
            for (i = 0; i <= 7; i++)
            {
                Console.Write("Entre com o B[{0}] valor: ", i + 9);
                B[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= 7; i++)
            {
                C[i+8] = B[i];
            }

            Console.WriteLine();

            Console.WriteLine("Matriz A");
            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine("A[{0}]", A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Matriz B");
            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine("B[{0}]", B[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Matriz C");
            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine("C[{0}]", C[i]);
            }

            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine("C[{0}]", C[i + 8]);
            }

            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }
    }
}
