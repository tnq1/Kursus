using System;
using System.Collections.Generic;

namespace M75_1_ListStackDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // List
            List<int> lst = new List<int>();

            lst.Add(1);
            lst.Add(3);
            lst.Add(5);
            foreach (var item in lst)
            {
                Console.WriteLine($"item: {item}");
            }

            // Stack

            Stack<DateTime> stackDate = new Stack<DateTime>();

            stackDate.Push(new DateTime(2020, 05, 01));

            stackDate.Push(new DateTime(2020, 06, 01));

            stackDate.Push(new DateTime(2020, 07, 01));


            //foreach (var item in stackDate)
            //{
            //    Console.WriteLine($"StackDate: {item}");
            //}

            foreach (var item in stackDate)
            {
                Console.WriteLine(item);
            }
            DateTime d = stackDate.Pop();
            Console.WriteLine(d);

            //Dictionary

            Dictionary<int, string> lstDictionary = new Dictionary<int, string>();

            lstDictionary.Add(1, "lst1");
            lstDictionary.Add(2, "lst2");
            lstDictionary.Add(3, "lst3");

            foreach (var item in lstDictionary)
            {
                Console.WriteLine($"Dictionary item:  {item}");
            }



        }
    }
}
