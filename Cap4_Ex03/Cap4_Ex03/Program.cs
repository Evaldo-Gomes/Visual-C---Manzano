using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            long FAT = 1, N, i;

            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());

            for (i =1; i <= N; i++)
            {
                FAT *= i;
            }

            Console.WriteLine();
            Console.WriteLine("Fatorial de {0} = {1}.", N, FAT);

        }
    }
}
