using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate int SomeOperation(int i, int j, int k); //Delegate declaration

        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        static int Subtract(int x, int y, int z)
        {
            return x - y - z;
        }

        static int Multiply(int x, int y, int z)
        {
            return x * y * z;
        }

        static int Divide(int x, int y, int z)
        {
            return x / y / z;
        }

        static void Main(string[] args)
        {

            //Lambda practice:
            Func<string, int> test = x => x.Length; //Lambda expression - x is the string, x.length is the int
            Console.WriteLine(test("Hello world!")); //Returns 12
            Func<int, int, int> test2 = (x, y) => x * y; //Lambda expression - x and y are the input ints, x * y is the output int
            Console.Write(test2(12, 12)); //Returns 144
            Console.ReadLine();

            Console.WriteLine("-------------------------");
            Func<bool, int> del = x => x ? 10 : 5; //Returns 10 if true, 5 if false
            SomeOperation add = Sum; //Delegate instantiation - add is now a reference to the Sum method
            SomeOperation divide = Divide;
            SomeOperation multiply = Multiply;
            SomeOperation subtract = Subtract;
            int result = add(10, 10, 10);
            Console.WriteLine(del(false)); //Returns false
            Console.WriteLine(del(true)); //Returns true
            Console.WriteLine("-------------------------");
            Console.WriteLine(result); //add
            Console.WriteLine(subtract(10, 10, 10));
            Console.WriteLine(divide(10, 10, 10));
            Console.WriteLine(multiply(10, 10, 10));
            Console.WriteLine("-------------------------");

            List<int> elements = new List<int> { 1, 2, 3, 4, 5 };
            //Finds the index of the first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0); //x is the element in the list, => is the lambda operator, x % 2 != 0 is the condition.
            Console.WriteLine(oddIndex);
            Console.WriteLine("-------------------------");

            //Implicitly-typed Lambda Expressions:
            Func<int, int> func1 = x => x + 1; //Callable lambda expression
            Console.WriteLine("FUNC1: {0}", func1.Invoke(5)); //Invoke is a method that calls the lambda expression

            Func<int, int> func2 = x => { return x + 1; }; //Callable lambda expression with a statement
            Console.WriteLine("FUNC 2: {0}", func2.Invoke(10));

            Func<int, int> func3 = (int x) => x + 1; //Callable lambda expression with formal parameters
            Console.WriteLine("FUNC 3: {0}", func3.Invoke(15));

            Func<int, int> func4 = (int x) => { return x + 1; }; //Callable lambda expression with formal parameters and a statement
            Console.WriteLine("FUNC 4: {0}", func4.Invoke(20));

            Action value = () => Console.WriteLine("Hello world."); //Lambda expression with no parameters - called an Action.
            value.Invoke();
            Console.WriteLine("-------------------------");

            var array = new int[] { 1, 2, 3, 4, 5 };
            var result2 = Array.Find(array, element => element > 2); //Finds the first element greater than 2
            var result3 = Array.FindAll(array, element => element > 2); //Finds all elements greater than 2
            foreach (var r in result3)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
        }
    }
}
