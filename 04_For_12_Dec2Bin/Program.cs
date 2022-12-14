using System;

namespace _04_For_12_Dec2Bin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dec = 147;

            string binJinak = Convert.ToString(dec, 2);
            Console.WriteLine(binJinak);

            string bin = "";

            while (dec > 0)
            {
                bin = (dec % 2) + bin;
                dec /= 2;
            }

            Console.WriteLine(bin);

        }
    }
}