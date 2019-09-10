using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap6_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] MDG = new float[8];
            float SOMA = 0, MEDIA;
            int i;

            for (i = 0; i <= 7; i++)
            {
                Console.Write("Média do {0} aluno: ", i + 1);
                MDG[i] = float.Parse(Console.ReadLine());
                SOMA += MDG[i];
            }

            MEDIA = SOMA / 8;

            Console.WriteLine();
            Console.WriteLine("Média Geral {0:0.00}", MEDIA);

            Console.WriteLine();
            Console.Write("Tecle <enter> para encerrar...");
            Console.WriteLine();
        }
    }
}

