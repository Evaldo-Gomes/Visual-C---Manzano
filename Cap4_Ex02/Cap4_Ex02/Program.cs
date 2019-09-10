using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            long FAT = 1, N, i;

            Console.Write("Informe um valor: ");
            N = long.Parse(Console.ReadLine());

            i = 1;
            do
            {
                FAT *= i;
                i++;
            }
            while (i <= N);

            Console.WriteLine();
            Console.WriteLine("Fatorial de {0} = {1}", N, FAT);

        }
    }
}
