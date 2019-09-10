using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LER MATRIZ A, CONSTRUIR MATRIZ B = A^2*/

namespace Cap6_Ex_Fix06
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int[] B = new int[10];
            int i;

            for (i = 0; i <= 9; i++)
            {
                Console.Write("Entre como valor de A[{0}]: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
                B[i] = A[i] * A[i];
            }

            Console.WriteLine();

            for (i = 0; i <= 9; i++)
            {
                Console.Write("A[{0}] ^ 2 = ", A[i]);
                Console.WriteLine("B[{0}])", B[i]);
            }
            Console.WriteLine();
            Console.Write("Tecle algo para continuar...");
        }
    }
}
