using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap3_Ex06
{
    class Program
    {
        static void Main(string[] args)
        {

            float A, B, C;

            Console.Write("Informe o lado A: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado B: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Informe o lado C: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (A < B + C && B < A + C && C < A + B)
                if (A == B && B == C)
                    Console.WriteLine("Triângulo Equilátero");
                else
                    if (A == B || A == C || C == B)
                    Console.WriteLine("Triângulo Isósceles");
                else
                    Console.WriteLine("Triângulo Escaleno");
            else
                Console.WriteLine("Valores não formam um triângulo");


                    Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
