using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3___Development_C
{
    class ClassB : ClassA, Interface1
    {
        public void A_Funcionality(string str1, string str2, List<int> list1, List<int> list2)
        {
            base.CompareLenght(str1, str2);
            base.CompareSize(list1, list2);
            Console.WriteLine("A funcionality Executed from Class B");
        }

        public void PrintHello()
        {
            Console.WriteLine("\nHello Interface");
        }

    }
}
