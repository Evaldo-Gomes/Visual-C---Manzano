using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LER MATRIZ A E B, APRESENTAR MATRIZ C = A - B*/

namespace Cap6_Ex_Fix03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            int[] A = new int[9];
            int[] B = new int[9];
            int[] C = new int[9];

            for (i = 0; i <= 8; i++)
            {
                Console.Write("Entre com o A[{0}] valor: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (i = 0; i <= 8; i++)
            {
                Console.Write("Entre com o B[{0}] valor: ", i + 1);
                B[i] = int.Parse(Console.ReadLine());
            }
            
            for (i = 0; i <= 8; i++)
            {
                C[i] = A[i] - B[i];
            }

            Console.WriteLine();

            for (i = 0; i <= 8; i++)
            {
                Console.Write("C[{0}] = ", C[i]);
                Console.Write("A[{0}] - ", A[i]);
                Console.WriteLine("B[{0}]", B[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
        }
    }
}
