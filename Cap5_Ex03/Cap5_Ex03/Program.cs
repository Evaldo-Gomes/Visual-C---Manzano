using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap5_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            byte X;

            Console.Title = "Programa Fatorial";
            Console.Write("Entre com um valor numérico: ");
            X = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            Fatorial(X);

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");
            Console.ReadKey();
        }

        public static void Fatorial (byte N)
        {
            long FAT = 1;
            if (N == 0)
                FAT = 0;
            else
                for (int i = 1; i <= N; i++)
                    FAT *= i;
                Console.WriteLine("Fatorial de {0} = {1}", N, FAT); //PARÂMETRO PASSADO DENTRO DO MÉTODO Fatorial
        }

    }
}
