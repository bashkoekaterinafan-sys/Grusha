using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "вертикаль";

            var result1 = word.Substring(3, 2) + word.Substring(2, 1);
            var result2 = word.Remove(2) + word.Substring(3, 1) + word.Substring(5, 2);

            Console.WriteLine($"Было слово \"{word} \".");
            Console.WriteLine($"Мы получили слова \"{result1}\" и \"{result2}\".");
        }
    }
}
