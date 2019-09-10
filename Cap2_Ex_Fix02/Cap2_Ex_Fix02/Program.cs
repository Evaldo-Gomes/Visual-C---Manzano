using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*CÁLCULO DO CONSUMO DE COMBUSTÍVEL - (12KM/L)*/

namespace Cap2_Ex_Fix02
{
    class Program
    {
        static void Main(string[] args)
        {

            float L, VM, DIST;
            int T;

            Console.Write("Qual foi o tempo gasto na viajem? - (H): ");
            T = int.Parse(Console.ReadLine());
            Console.Write("Qual foi a velocidade média?: - (km/h): ");
            VM = float.Parse(Console.ReadLine());

            DIST = T * VM;
            L = DIST / 12;

            Console.Write("");
            Console.WriteLine("Com velocidade média de " + VM + " km/h");
            Console.WriteLine("Tempo gosto de " + T + " h ");
            Console.WriteLine("");
            Console.WriteLine("A distância calculada foi de " + DIST + " km ");
            Console.WriteLine("");
            Console.WriteLine("Seu consumo calculado fazendo 12km por litro é de: " + L.ToString("##,##0.00") + "km/l");


        }
    }
}
