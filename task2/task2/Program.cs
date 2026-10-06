using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            var number = int.Parse(Console.ReadLine());

            var hundreds = number / 100;
            var tens = number / 10 - hundreds * 10;
            var units = number - hundreds * 100 - tens * 10;

            var result = units * 100 + tens * 10 + hundreds;

            Console.WriteLine("Вот результат: " + result);


            Console.ReadKey();

        }
    }
}
