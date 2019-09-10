using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*MULTIPLICAÇÃO DA MATRIZ A POR 3, RESULTANDO A MATRIZ B*/

namespace Cap6_Ex_Fix01
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[8];
            int[] B = new int[8];
            int i;

            for(i = 0; i <= 7; i++)
            {
                Console.Write("Insira o {0}° valor: ", i + 1);
                A[i] = int.Parse(Console.ReadLine());
                B[i] = A[i] * 3;
            }
            Console.WriteLine();
            for (i = 0; i <= 7; i++)
            {
                Console.Write("Valor A[{0}] * 3 = ", A[i]);
                Console.WriteLine("Valor B[{0}]", B[i]);
            }
            Console.WriteLine();
        }
    }
}
