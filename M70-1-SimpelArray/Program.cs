using System;

namespace M70_1_SimpelArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            int total = 0;

            //for (int i = 0; i < månedsløn.Length; i++)
            //{
            //    Console.WriteLine(månedsløn[i]);
            //    total += månedsløn[i];
            //}

            foreach (var item in månedsløn)
            {
                Console.WriteLine(item);
                total += item;
            }

            double gennemsnit = total / månedsløn.Length ;
            Console.WriteLine($"gennemsnit:  {gennemsnit.ToString("N2")}");

            System.Array.Sort(månedsløn);
            Console.WriteLine(string.Join(",",månedsløn));
        }
    }
}
