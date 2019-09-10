using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, i, R;
            string RESP;

            RESP = "S";
            while (RESP.ToUpper() == "S")
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA - TABUADA 2.0");
                Console.WriteLine();
                Console.Write("Informe um valor: ");
                N = int.Parse(Console.ReadLine());
                Console.ReadLine();

                for (i = 1; i <= 10; i++)
                {
                    R = N * i;
                    Console.WriteLine("{0,2} X {1,2} = {2,3}", N, i, R);
                }

                Console.WriteLine();
                Console.WriteLine("Deseja continuar?");
                Console.Write("[S] para SIM ou [N] para NÂo: ");
                RESP = Console.ReadLine();
                Console.WriteLine();
            }

        }
    }
}
