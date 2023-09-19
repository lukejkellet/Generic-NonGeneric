using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            var Numbers = new List<int> { 1, 2, 3, 4 };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            foreach (var number in Numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
