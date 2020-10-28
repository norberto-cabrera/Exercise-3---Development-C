using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_3___Development_C
{
    class ClassA
    {
        public void CompareLenght(string str1, string str2)
        {
            if (str1.Length == str2.Length)
                Console.WriteLine("The lenght of the strings \"{0}\" , \"{1}\" are same",str1,str2);
            else
                Console.WriteLine("The lenght of the strings \"{0}\" , \"{1}\" are different", str1, str2);
        }

        public void CompareSize(List<int> list1, List<int> list2)
        {
            if (list1.Count==list2.Count)
                Console.WriteLine("The size of the lists \"{0}\" , \"{1}\"  are same",list1.Count,list2.Count);
            else
                Console.WriteLine("The size of the lists \"{0}\" , \"{1}\"  are different",list1.Count,list2.Count);
        }
    }
}
