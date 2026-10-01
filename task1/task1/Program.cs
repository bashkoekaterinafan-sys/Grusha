using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue; 
            Console.WriteLine("Михаил Юрьевич Лермонтов"); 

            Console.ForegroundColor = ConsoleColor.DarkRed; 
            Console.WriteLine("Парус"); Console.WriteLine(); 

            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Белеет парус одинокий");
            
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine("В тумане моря голубом!.."); 

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Что ищет он в стране далекой?");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Что кинул он в краю родном?..");


            Console.ResetColor(); 
            
            
            Console.ReadKey();
        }
    }
}
