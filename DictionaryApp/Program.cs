using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> numberNames = new Dictionary<string, int>();
            numberNames.Add("Joe", 22);
            numberNames.Add("Bob", 25);
            numberNames.Add("Zoe", 28);
            foreach (KeyValuePair<string, int> keyValuePair in numberNames)
            {
                Console.WriteLine("Key = {0}, Value = {1}", keyValuePair.Key, keyValuePair.Value);
            }
            IDictionary<string, string> objectTypes = new Dictionary<string, string>();
            objectTypes.Add("Fruits", "Apple, banana, orange");
            objectTypes.Add("Vegetables", "Carrot, potato, onion");

            foreach (KeyValuePair<string, string> keyValuePair in objectTypes)
            {
                Console.WriteLine("Key = {0}, Value = {1}", keyValuePair.Key, keyValuePair.Value);
            }
            objectTypes["Fruits"] = "Apple, banana, orange, strawberry";
            Console.WriteLine(objectTypes["Fruits"]);
            numberNames.Remove("Joe");
            Console.WriteLine(numberNames.Count);
            Console.ReadLine();
        }
    }
}
