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

            float A, B, C, X;

            Console.Write("Entre com o valor <A>: ");
            A = float.Parse(Console.ReadLine());
            Console.Write("Entre com o valor <B>: ");
            B = float.Parse(Console.ReadLine());
            Console.Write("Entre com o valor <C>: ");
            C = float.Parse(Console.ReadLine());

            Console.WriteLine();
            if (!(C > 5))
                X = (A + B) * C;
            else
                X = (A - B) * C;

            Console.Write("O resultado de X equivale a: " + X);

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();


        }
    }
}
