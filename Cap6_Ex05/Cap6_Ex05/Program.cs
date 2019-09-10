using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*LEITURA DE 9 VALORES INTEIROS EM UMA MATRIX 3X3*/
/*APRESENTAÇÃO DOS VALORES DA DIAGONAL PRINCIPAL*/

namespace Cap6_Ex05
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] A = new int[3, 3];
            int i, j, LIN = 7, COL = 0;

            Console.SetCursorPosition(0, 0);
            Console.Write("Entre com  um valor na coordenada: ");
            Console.SetCursorPosition(0, 2);
            Console.Write("Linha...: ");
            Console.SetCursorPosition(0, 3);
            Console.Write("Coluna...: ");
            
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("{0}", i + 1);
                    Console.SetCursorPosition(11, 3);
                    Console.Write("{0}", j + 1);
                    Console.SetCursorPosition(0, 5);
                    Console.Write("--> ");
                    A[i, j] = int.Parse(Console.ReadLine());
                    Console.SetCursorPosition(4, 5);
                    Console.Write("    ");
                    Console.SetCursorPosition(COL, LIN);
                    Console.Write("{0,4}", A[i, j]);
                    COL += 6;
                }
                LIN += 2;
                COL -= 18;
            }

            Console.SetCursorPosition(0, 13);
            Console.Write("Saída - Diagonal Principal");
            Console.SetCursorPosition(0, 15);

            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    if (i == j)
                    {
                        Console.Write("A[{0},{1}]", i + 1, j + 1);
                        Console.WriteLine(" = {0,4}", A[i, j]);
                    }
                }
            }

            Console.WriteLine();
            Console.Write("Tecle algo para continuar...");
        }
    }
}
