using System;

namespace _05_Pole_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pole - array ... vic hodnot stejneho datoveho typu
            string[] sousedi = new string[3]; //3 - je delka pole, tedy počet položek

            sousedi[0] = "Novákovi";
            sousedi[1] = "Černí";
            sousedi[2] = "Procházkovi";

            Console.WriteLine(sousedi[1]);
            Console.WriteLine();

            for (int i = 0; i < sousedi.Length; i++)
            {
                Console.WriteLine(sousedi[i]);
            }

            Console.WriteLine();

            for (int i = sousedi.Length - 1; i > -1; i--)
            {
                Console.WriteLine(sousedi[i]);
            }

            //deklarace a inicializace pole zároveň
            int[] fibonacci = { 1, 1, 2, 3, 5, 8, 13, 21 };
            for (int i = 0; i < fibonacci.Length; i++)
            {
                Console.WriteLine(fibonacci[i]);
            }
        }
    }
}