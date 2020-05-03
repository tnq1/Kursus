using Microsoft.VisualBasic;
using System;
using System.Threading;

namespace M70_2_2_Dimension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[,] tab = new string[4,2];
      


            tab[0, 0] = "1";
            tab[1, 0] = "2";
            tab[2, 0] = "3";
            tab[3, 0] = "4";
            tab[0, 1] = "navn1";
            tab[1, 1] = "navn2";
            tab[2, 1] = "navn3";
            tab[3, 1] = "navn4";

            string navn = FindNavn(tab, "2");          
            Console.WriteLine($"navn: {navn}");

        }

        static string FindNavn(string[,] navn, string id)
        {
            for (int i = 0; i < navn.GetLength(0); i++)
            {
                if (id == navn[i,0])
                {
                    return navn[i, 1];
                }              

            }
            return " ";

        }
    }
}
