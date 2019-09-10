using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TROCA DE VALORES*/

namespace Cap2_Ex_Fix06
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, X;

            Console.Write("Insira o primeiro número (A): ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo número (B): ");
            B = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Valor de (A): " + A);
            Console.WriteLine("Valor de (B): " + B);

            X = A;
            A = B;
            B = X;

            Console.WriteLine("Após as troca:");
            Console.WriteLine();
            Console.WriteLine("Valor de (A): " + A);
            Console.WriteLine("Valor de (B): " + B);
        }
    }
}
