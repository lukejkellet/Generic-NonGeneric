using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(5); //first in last out
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(20); //last in first out
            //essentially, it reads the items in reverse order.

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Stack<int> myStack2 = new Stack<int>(array);
            foreach (var item in myStack2)
            {
                //5 is the first item to be output, because it is the last item in the array.
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
            Console.WriteLine(myStack.Peek()); //returns 20
            myStack.Pop(); //removes the top item from the stack
            Console.WriteLine(myStack.Peek()); //returns 15
            Console.WriteLine("-------------------------");
            Console.WriteLine(myStack.Contains(5)); //returns true
            Console.WriteLine(myStack.Contains(6)); //returns false
            myStack.Clear(); //removes all items from the stack
            Console.WriteLine(myStack.Count);
            Console.WriteLine(myStack.Equals(myStack2)); //returns false
            Console.WriteLine(myStack.Equals(myStack)); //returns true

            Type myType = myStack.GetType();
            Console.WriteLine(myType);

            ArrayList myArray = new ArrayList();
            myArray.Add(1);
            myArray.Add(2);
            myArray.Add(3);
            myArray.Add("Four");

            IEnumerable<string> query = myArray.OfType<string>();
            IEnumerable<int> ints = myArray.OfType<int>();

            foreach (var item in query)
            {
                Console.WriteLine(item); //Outputs items ofType specified in query
            }
            Console.ReadLine();
        }
    }
}
