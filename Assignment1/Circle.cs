using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    using System;

    class Circle
    {
        static double circumference(double r)
        {

            double PI = 3.1415;
            double cir = 2 * PI * r;
            return cir;
        }
        public static void Main()
        {

            double r;
            Console.Write("Enter Radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            double result =
                  Math.Round(circumference(r)
                            * 1000) / 1000.0;

            Console.WriteLine("Circumference = "
                                      + result);
        }
    }

}
