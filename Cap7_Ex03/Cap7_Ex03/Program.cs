using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*AÇÃO POLIMÓRFICA + ARRANJO DINÂMICO*/
/*POLIMORFISMO UNIVERSAL PARAMÉTRICO*/

namespace Cap7_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Object> LISTA = new List<object>();

            int T;
            String N;

            //Entrada dos nomes

            Console.WriteLine();
            Console.Write("Quantos nomes a dar entrada? ");
            T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.Write("Entre o {0,3}° nome: ", i + 1);
                N = Console.ReadLine();
                LISTA.Add(N);
            }

            //Apresentação dos nomes

            Console.WriteLine();
            for (int i = 0; i < LISTA.Count; i++)
            {
                N = LISTA[i].ToString();
                Console.WriteLine("{0,3}° nome = {1}", i + 1, N);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para encerrar...");

        }
    }
}
