using System;
using System.Diagnostics;

namespace _04_For_13_Je_prvocislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 49;
            bool jePrvocislo = true;

            Stopwatch stopky = new Stopwatch();

            stopky.Start();

            for (int i = 0; i < 100000; i++)
            {
                cislo = i;

                //int maxDelitel = cislo / 2; //větším nemá cenu dělit
//                double maxDelitel = Math.Sqrt(cislo); //ve skutečnosti zde je hranice

                //for (int delitel = 2; delitel <= maxDelitel; delitel++)
                //for (int delitel = 2; delitel <= Math.Sqrt(cislo); delitel++)
                for (int delitel = 2; delitel < cislo; delitel++)
                {
                    if (cislo % delitel == 0)
                    {
                        jePrvocislo = false; //našel jsem dělitele - není to prvočíslo
                        break;
                    }
                }

                //if (jePrvocislo)
                //    Console.WriteLine("{0} je prvočíslo.", cislo);
                //else
                //    Console.WriteLine("{0} je číslo složené.", cislo);

            }

            stopky.Stop();

            Console.WriteLine(stopky.ElapsedMilliseconds);
        }
    }
}