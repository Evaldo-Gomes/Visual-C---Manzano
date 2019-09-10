using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap2_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {

            float HT, VH, PD, SB, TD, SL;

            Console.Write("Horas trabalhadas ....................: ");
            HT = float.Parse(Console.ReadLine());
            Console.Write("Valor da hora ........................: ");
            VH = float.Parse(Console.ReadLine());
            Console.Write("Valor do percentual de desconto ........");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;
            TD = (PD / 100) * SB;
            SL = SB - TD;

            Console.WriteLine();
            Console.Write("Salário Líquido ................... ");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.Write("tecle <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
