using System;
using System.Linq.Expressions;

namespace M70_3_ArraySplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";
            string[] array = txt.Split(';');
            Console.WriteLine(string.Join(",", array));

            int total = 0;
            int element = 0;
            for (int i = 0; i < array.Length; i++)
            {
                element = Convert.ToInt32(array[i]);
                total += element;
            }

            Console.WriteLine($"Total: {total:N2}");

        }
    }
}
