using System;

namespace _03_While_13_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            int cislo;
            string nacteno;

            //do
            //{
            //    Console.WriteLine("Zadej číslo, nebo x pro ukončení.");
            //    nacteno = Console.ReadLine();

            //    if (int.TryParse(nacteno, out cislo))
            //    {
            //        suma += cislo;
            //    }
            //    else if (nacteno != "x")
            //    {
            //        Console.WriteLine("Chybné zadání");
            //    }

            //}
            //while (nacteno != "x");

            //Console.WriteLine("Součet byl {0}", suma);

            while (true)
            {
                Console.WriteLine("Zadej číslo, nebo x pro ukončení.");
                nacteno = Console.ReadLine();

                if (nacteno == "x")
                    break;

                if (int.TryParse(nacteno, out cislo))
                {
                    suma += cislo;
                }
                else
                {
                    Console.WriteLine("Chybné zadání");
                }

            }

            Console.WriteLine("Součet byl {0}", suma);
        }
    }
}