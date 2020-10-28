using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Exercise_3___Development_C
{
    class Program
    {

        static void order(List<String> names, string order)
        {
            if (order == "asc")
            {
                names.Sort();
                Console.WriteLine("\nAfter sort Acsendent:");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            else
            {
                names.Sort();
                names.Reverse();
                Console.WriteLine("\nAfter sort Descendent:");
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }

        static void NoWhiteSpace (List<String> names)
        {
            foreach (string name in names)
            {
                string trimmed = String.Concat(name.Where(c => !Char.IsWhiteSpace(c)));
                Console.WriteLine(trimmed);

            }
        }

        static void DistinctNumbers (List<int> numbers)
        {
            IEnumerable<int> distinctNumbers = numbers.Distinct();

            Console.WriteLine("Numbers that are not duplicated: ");

            foreach (int number in distinctNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            ClassB obj = new ClassB();
            String str1 = "hola";
            String str2 = "cola";
            List<int> list1 = new List<int>() { 1, 2, 3 };
            List<int> list2 = new List<int>() { 4, 5, 6 };
            obj.A_Funcionality(str1, str2, list1, list2);
            obj.PrintHello();

            List<String> names = new List<String>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            Console.WriteLine("\nOriginal list: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            order(names, "asc");
            order(names, "des");
            Console.WriteLine("After filtering white spaces: ");
            NoWhiteSpace(names);

            List<int> numbers = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            DistinctNumbers(numbers);
        }
    }
}
