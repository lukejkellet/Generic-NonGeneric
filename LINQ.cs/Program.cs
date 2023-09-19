using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string likes = "I like fruit";
            string[] fruit = { "apple", "banana", "orange", "strawberry" };
            int[] numbers = { 1, 2, 3, 4, 5 };
            var getNumbers = from number
                             in numbers
                             where number > 2
                             select number;
            Console.WriteLine(string.Join(", ", getNumbers));
            Console.ReadLine();
            var getGLen = from item
                          in fruit
                          where item.Contains("g")
                          where item.Length < 8
                          select item;
            Console.WriteLine(string.Join(", ", getGLen));
            Console.ReadLine();
            var getEvenNumbers = from number
                                 in numbers
                                 where number % 2 == 0
                                 select number;
            Console.WriteLine(string.Join(", ", getEvenNumbers));
            Console.ReadLine();
        }
    }
}
