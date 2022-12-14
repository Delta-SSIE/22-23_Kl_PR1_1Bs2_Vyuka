using System;

namespace _04_For_11_Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin = "10010011";
            int baze = 1;
            int cislo = 0;

            for (int i = 0; i < bin.Length; i++)
            {
                char bit = bin[bin.Length - 1 - i];
                
                if (bit == '1')
                    cislo += baze;
                //cislo += Math.Pow(2, i);
                
                baze *= 2;
            }

            Console.WriteLine(cislo);

            int cisloJinak = Convert.ToInt32(bin, 2);
            Console.WriteLine(cisloJinak);
        }
    }
}