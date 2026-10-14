using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onLesson07._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Calculate();
            Console.WriteLine("Result: " + Math.Round(x, 3));
            
        }

        
        static double Calculate() => F(5, 7) * F(12, 8) * F(31, 2);
        static double F(double x, double y) => (x + Math.Sqrt(x)) / (y + Math.Sqrt(y));
    }
}
