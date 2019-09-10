using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*VOLUME DE UM GALÃO*/

namespace Cap2_Ex_Fix05
{
    class Program
    {
        static void Main(string[] args)
        {

            double H, D, R, V;

            Console.Write("Insira a altura do galão em centímetros - (cm): ");
            H = double.Parse(Console.ReadLine());
            Console.Write("Insira o diâmetro da base do galão em centímetros - (cm): ");
            D = double.Parse(Console.ReadLine());

            R = D / 2;
            V = 3.14159 * (Math.Pow(R,2)) * H;

            Console.WriteLine();
            Console.WriteLine("O volume calculado do galão é de aproximadamente: " + V.ToString("##0") + " cm3");          
        }
    }
}
