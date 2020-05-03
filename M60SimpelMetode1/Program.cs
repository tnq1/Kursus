using System;

namespace M60SimpelMetode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53
            //double res3 = BeregnBeløbEfterMoms(100, .25);
            //Console.WriteLine(res3); // 125
            //Udskriv("Dette er en test"); // Dette er en test
        }

        static int LægSammen ( int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal ( double radius)
        {
            return radius;
        }
    }
}
