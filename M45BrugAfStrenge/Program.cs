using System;

namespace M45BrugAfStrenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";
            string samletNavn = forNavn + " " + efterNavn;
            Console.WriteLine("Navn:");
            Console.WriteLine(samletNavn);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine("navnLille:");
            Console.WriteLine(navnLille);


            string navnStor = samletNavn.ToUpper();
            Console.WriteLine("navnStor:");
            Console.WriteLine(navnStor);


            string delAfNavn = efterNavn.Substring(0, 4);

            Console.WriteLine("delAfNavn:");
            Console.WriteLine(delAfNavn);
            

            Console.WriteLine(forNavn + "\r\n\t" + efterNavn);
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            string samletNavn2 = $"{forNavn} {efterNavn}";

        }
    }
}
