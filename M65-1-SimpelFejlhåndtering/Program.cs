using System;

namespace M65_1_SimpelFejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run();
            PrøvIgen();
        }
        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
        static void PrøvIgen()
        {
            int prøvMaxAntal = 3;

            int antal                = 0;

            while (antal < prøvMaxAntal)
            {
                try
                {
                    Run();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Der er sket en fejl " + ex.Message);
                    antal++;
                }
            }
        }
    }
}
