using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9};

            PrintNumbers("Number",numbers) ;
            PrintNumbers("Even No", numbers.Where(x => IsEven(x)));
            PrintNumbers("Odd No", numbers.Where(x => IsOdd(x)));

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
        static void PrintNumbers (string title, IEnumerable<int> numbers)
        {
            Console.Write($"{title}: [");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.Write($"]");
            Console.WriteLine();
        }
        static bool IsEven (int number)
        {
            if (number % 2 == 0) return true;
            else return false;
        }
        static bool IsOdd(int number)
        {
            if (number % 2 != 0) return true;
            else return false;
        }
    }
}
