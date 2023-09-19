using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double average;
            int grade;
            int total = 0;
            int max = 0;
            ArrayList grades = new ArrayList();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                grade = rand.Next(1, 100);
                grades.Add(grade);
            }
            for (int i = 0; i < grades.Count; ++i)
            {
                Console.WriteLine(i + 1 + " " + grades[i]);
                if ((int)grades[i] > max)
                {
                    max = (int)grades[i];
                }
                total += (int)grades[i];
            }
            average = total / grades.Count;
            Console.WriteLine("Average is {0}", average);
            Console.WriteLine("Highest grade is {0}", max);
            Console.ReadLine();
        }
    }
}

//How an ArrayList works:
//An ArrayList is a dynamic array whose size changes as needed during runtime.
//It is part of Systems.Collections, and it can hold any type of data.
//It is a reference type, so it is passed by reference.
//Its methods include Add, Clear, Contains, IndexOf, Insert, Remove, RemoveAt, Sort, and ToArray.