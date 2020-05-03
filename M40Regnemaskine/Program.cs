using System;

namespace M40Regnemaskine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine(tal1);
            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            double t1 = System.Convert.ToDouble(tal1);
            double t2 = System.Convert.ToDouble(tal2);

            double total = t1 + t2;

            Console.WriteLine("Total:");
            Console.WriteLine(total.ToString("N2"));

            //Løsningsforslag

            //Console.WriteLine("Indtast tal 1");
            //string tal1 = Console.ReadLine();

            //Console.WriteLine("Indtast tal 2");
            //string tal2 = Console.ReadLine();

            //double t1 = System.Convert.ToDouble(tal1);
            //double t2 = System.Convert.ToDouble(tal2);

            //double resultat = t1 + t2;
            //Console.WriteLine("Resultatet er");
            //Console.WriteLine(resultat.ToString("N2"));
        }
    }
}
