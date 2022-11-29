using System;

namespace _04_For_05_Obdelniky_a_trojuhelniky
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //obdelnik
            //int vyska = 6;
            //int sirka = 4;
            //char znak = '#';

            //for (int y = 0; y < vyska; y++)
            //{
            //    for (int x = 0; x < sirka; x++)
            //    {
            //        Console.Write(znak);
            //    }
            //    Console.WriteLine();
            //}

            //trojuhelnik b
            //int vyska = 16;
            //char znak = '#';

            //for (int y = 0; y < vyska; y++)
            //{
            //    int pocetZnaku = y + 1;

            //    for (int x = 0; x < pocetZnaku; x++)
            //    {
            //        Console.Write(znak);
            //    }

            //    Console.WriteLine();
            //}

            //trojuhelnik p
            //int vyska = 16;
            //char znak = '#';

            //for (int y = 0; y < vyska; y++)
            //{
            //    int pocetZnaku = vyska - y;

            //    for (int x = 0; x < pocetZnaku; x++)
            //    {
            //        Console.Write(znak);
            //    }

            //    Console.WriteLine();
            //}


            //trojuhelnik q
            //int vyska = 16;
            //char znak = '#';

            //for (int y = 0; y < vyska; y++)
            //{
            //    int pocetMezer = y;
            //    int pocetZnaku = vyska - y;

            //    for (int x = 0; x < pocetMezer; x++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int x = 0; x < pocetZnaku; x++)
            //    {
            //        Console.Write(znak);
            //    }

            //    Console.WriteLine();
            //}


            //trojuhelnik d
            //int vyska = 16;
            //char znak = '#';

            //for (int y = 0; y < vyska; y++)
            //{
            //    int pocetZnaku = y + 1;
            //    int pocetMezer = vyska - pocetZnaku;

            //    for (int x = 0; x < pocetMezer; x++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int x = 0; x < pocetZnaku; x++)
            //    {
            //        Console.Write(znak);
            //    }

            //    Console.WriteLine();
            //}

            //trojuhlenik delta (pyramida)
            int vyska = 16;
            char znak = '#';

            for (int y = 0; y < vyska; y++)
            {
                int pocetZnaku = 2 * y + 1;
                int pocetMezer = vyska - y;

                for (int x = 0; x < pocetMezer; x++)
                {
                    Console.Write(' ');
                }
                for (int x = 0; x < pocetZnaku; x++)
                {
                    Console.Write(znak);
                }

                Console.WriteLine();
            }
        }
    }
}