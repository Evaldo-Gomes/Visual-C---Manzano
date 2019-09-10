using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ARRANJO - APRESENTAÇÃO DE 5 STRINGS EM ORDEM *ALFABÉTICA (*ASCII)*/

namespace Cap6_Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] NOME = new string[5];
            int i, j;
            string X;

            //Entrada de dados

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Entre com o {0}° nome: ", i + 1);
                NOME[i] = Console.ReadLine();
            }

            //Processamento ordenação

            for (i = 0; i <= 3; i++)
            {
                for (j = i + 1; j <= 4; j++)
                {
                    if (NOME[i].CompareTo(NOME[j]) > 0)
                    {
                        X = NOME[i];
                        NOME[i] = NOME[j];
                        NOME[j] = X;
                    }
                }
            }

            Console.ReadLine();

            //Apresentação dos arranjos

            Console.WriteLine("Lista de nomes ordenada");
            Console.WriteLine();

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine(NOME[i]);
            }

            Console.WriteLine();
            Console.Write("Tecle algo para continuar...");

        }
    }
}
