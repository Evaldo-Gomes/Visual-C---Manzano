using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Programa exemplo para cálculo de tabuada
 * de um valor numérico qualquer fornecido a partir
 * do teclado para operação em modo console.
 */

/*
 * Programa.............Tabuada
 * Autor(es)............Evaldo Gomes
 * Data.................04/08/2019
 * Versão...............2.0
 * Revisão..............04/08/2019
 */

namespace Cap4_Ex05
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
                    // Cálculo da tabuada propriamente dito
                    R = N * i;
                    // Apresentação da tabuada no formato N X i = R
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
