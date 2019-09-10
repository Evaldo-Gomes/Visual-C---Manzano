using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*DISPOR VALORE EM ORDEM CRESCENTE*/

namespace Cap3_Ex_Fix1
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, Primeiro, Segundo, Terceiro;

            Console.Write("Insira o primeiro valor: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira o segundo valor: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Insira o terceiro valor: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if ((A != B) && (A != C) && (B != C))
            {
                if ((A > B && A > C) && (B > C))
                {
                    Primeiro = A;
                    Segundo = B;
                    Terceiro = C;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }
                if ((A > B && A > C) && (C > B))
                {
                    Primeiro = A;
                    Segundo = C;
                    Terceiro = B;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }

                if ((B > A && B > C) && (A > C))
                {
                    Primeiro = B;
                    Segundo = A;
                    Terceiro = C;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }
                if ((B > A && B > C) && (C > A))
                {
                    Primeiro = B;
                    Segundo = C;
                    Terceiro = A;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }

                if ((C > A && C > B) && (A > B))
                {
                    Primeiro = C;
                    Segundo = A;
                    Terceiro = B;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }
                if ((C > A && C > B) && (B > A))
                {
                    Primeiro = C;
                    Segundo = B;
                    Terceiro = A;
                    Console.WriteLine("Menor valor:............................. {0}", +Terceiro);
                    Console.WriteLine("Valor intermediário:..................... {0}", +Segundo);
                    Console.WriteLine("Maior valor:............................. {0}", +Primeiro);
                }
            }
            else
            {
                Console.WriteLine("Insira três valores diferentes.");
                Console.Write("Tente novamente.");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
