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

            Console.WriteLine("Введите число: ");
            var x = double.Parse(Console.ReadLine());

            var y = Calculate(x);

            Console.WriteLine("f(x) = " + y);
        }


        static double Calculate(double x) => (x + (2 + Math.Cos(x)) / (x * x)) / (x + 1 / (Math.Sqrt(x * x + 10)));
    }
}
