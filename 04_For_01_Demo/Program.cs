using System;

namespace _04_For_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 1;
            //while (i < 11)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 101; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i > -1; i += 10)
            //{
            //    Console.WriteLine(i);
            //}

            //když chci aby se něco stalo opakovaně - 6 krát
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Něco dělám");
            }


            //když chci aby se něco stalo opakovaně - N krát
            int N = 20;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Něco dělám");
            }
        }
    }
}