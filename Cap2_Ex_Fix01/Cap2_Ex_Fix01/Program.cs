using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*DISTRIBUTIVA ENTRE QUATRO VALORES NUMÉRICOS*/

namespace Cap2_Ex_Fix01
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, D, D1, D2, D3, D4, D5, D6, S1, S2, S3, S4, S5;

            Console.Write("Insira o valor do primeiro número inteiro: ");
            A = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do segundo número inteiro: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do terceiro número inteiro: ");
            C = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor do quarto número inteiro: ");
            D = int.Parse(Console.ReadLine());

            D1 = A * B;
            D2 = A * C;
            D3 = A * D;
            D4 = B * C;
            D5 = B * D;
            D6 = C * D;

            S1 = D1 + D2;
            S2 = D3 + D4;
            S3 = D5 + D6;

            S4 = S1 + S2;

            S5 = S4 + S3;

            Console.WriteLine();
            Console.WriteLine("Primeira distributiva... " + A + " X " + B + " = " + D1);
            Console.WriteLine("Segunda distributiva... " + A + " X " + C + " = " + D2);
            Console.WriteLine("Terceira distributiva... " + A + " X " + D + " = " + D3);
            Console.WriteLine("Quarta distributiva... " + B + " X " + C + " = " + D4);
            Console.WriteLine("Quinta distributiva... " + B + " X " + D + " = " + D5);
            Console.WriteLine("Sexta distributiva... " + C + " X " + D + " = " + D6);
            Console.WriteLine();
            Console.WriteLine("Primeira somatória... " + D1 + " + " + D2 + " = " + S1);
            Console.WriteLine("Segunda somatória... " + D3 + " + " + D4 + " = " + S2);
            Console.WriteLine("Terceira somatória... " + D5 + " + " + D6 + " = " + S3);
            Console.WriteLine("Quarta somatória... " + S1 + " + " + S2 + " = " + S4);
            Console.WriteLine();
            Console.WriteLine("Resultado final... " + S4 + " + " + S3 + " = " + S5);
            Console.WriteLine();

        }
    }
}
