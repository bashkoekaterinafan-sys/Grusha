using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2fr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус: ");
            var r = double.Parse(Console.ReadLine());

            var length = 2 * r * 3.14159;
            var area = 3.14158 * r * r;

            Console.WriteLine("Вот площадь окружности: " + area);
            Console.WriteLine("Вот длина окружности: " + length);
        }

    }
}
