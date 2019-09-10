using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*SUBROTINA - SOMATÓRIO DO VALOR X DEFINIDO*/

namespace Cap5_Ex_Fix01
{
    class Program
    {
        public static int N, R, i;
        public static string Resp;

        static void Main(string[] args)
        {
            Console.Title = "Calculadora";
            Console.WriteLine("Calculadora de Somatório");
            Somatorio();
        }

        private static void Entrada()
        {
            Console.Write("Insira um valor inteiro positivo limite para somatório: ");
            N = int.Parse(Console.ReadLine());
        }

        private static void Saida()
        {
            Console.ReadLine();
            if (N >= 0)
            {
                Console.WriteLine("A somatória de todos os números inteiros até {0} = {1}", N, R);
                
            }
            else
            {
                Console.WriteLine("Digite apenas valores inteiros positivos.");
                Console.WriteLine();
                Console.WriteLine("Deseja tentar novamente? S - (SIM) N - (NÂO): ");
                Resp = Console.ReadLine();
                if (Resp != "N")
                {
                    Somatorio();
                }
            }
            Console.WriteLine();
        }

        public static int CalculoSoma(int X)
        {
            i = 1;
            while (i <= X)
            {
                R = R + i;
                i++;
            }
            return R;
        }

        private static void Somatorio()
        {
            Entrada();
            CalculoSoma(N);
            Saida();
        }
    }
}
