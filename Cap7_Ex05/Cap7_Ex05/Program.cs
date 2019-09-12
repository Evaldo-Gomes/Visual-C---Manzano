using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*POLIMORFISMO AD HOC*/

namespace Cap7_Ex05
{
    class Program
    {

        public class CalcArea
        {
            public long Area(int X)
            {
                long Area = X * X;
                return Area;
            }

            public int Area(int X, int Y, int Z)
            {
                int Area = X * Y * Z;
                return Area;
            }

            public double Area(float R, float H)
            {
                double Area = R * R * 3.14159 * H;
                return Area;
            }
        }

        static void Main(string[] args)
        {

            CalcArea A = new CalcArea();

            Console.WriteLine();
            Console.WriteLine("Calculo de Áreas");
            Console.WriteLine();
            Console.WriteLine("Quadrado ..: " + A.Area(5));
            Console.WriteLine("Cubo ......: " + A.Area(5, 6, 7));
            Console.WriteLine("Cilindro ..: " + A.Area(7, 3));
            Console.WriteLine();
        }
    }
}
