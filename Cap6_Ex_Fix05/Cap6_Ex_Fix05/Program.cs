using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LER MATRIZ A[5] E B[7], APRESENTAR MATRIZ C[12]*/

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

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Entre com o A[{0}] valor: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= 4; i++)
            {
                C[i] = A[i];
            }

            Console.WriteLine();

            for (i = 0; i <= 6; i++)
            {
                Console.Write("Entre com o B[{0}] valor: ", i + 6);
                B[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i <= 6; i++)
            {
                C[i + 5] = B[i];
            }

            Console.WriteLine();

            Console.WriteLine("Matriz A");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("A[{0}]", A[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Matriz B");
            for (i = 0; i <= 6; i++)
            {
                Console.WriteLine("B[{0}]", B[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Matriz C");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("C[{0}]", C[i]);
            }

            for (i = 0; i <= 6; i++)
            {
                Console.WriteLine("C[{0}]", C[i + 5]);
            }

            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }
    }
}
