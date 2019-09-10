using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LER MATRIZ A, CONSTRUIR MATRIZ INVERSA DE A = B*/

namespace Cap6_Ex_Fix07
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[8];
            int[] B = new int[8];
            int i;

            for (i = 0; i <= 7; i++)
            {
                Console.Write("Entre como valor de A[{0}]: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i <= 7; i++)
            {
                B[i] = A[7 - i];
            }

            Console.WriteLine();

            for (i = 0; i <= 7; i++)
            {
                Console.Write("A[{0}]   ", A[i]);
                Console.WriteLine("B[{0}]", B[i]);
            }
            Console.WriteLine();
            Console.Write("Tecle algo para continuar...");
        }
    }
}
