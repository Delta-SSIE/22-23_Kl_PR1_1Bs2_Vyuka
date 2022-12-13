using System.Runtime.CompilerServices;

namespace _05_Pole_02_Naplneni_a_vypis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zeptej se uživatele na 5 čísel, pak je vypiš v obráceném pořadí
            int n = 5;

            int[] cisla = new int[n];

            Console.WriteLine("Zadej {0} čísel:", n);
            Console.WriteLine();

            for (int i = 0; i < cisla.Length; i++)
            {
                Console.WriteLine("Zadej {0}. číslo:", i + 1);
                string zadano = Console.ReadLine();
                cisla[i] = int.Parse(zadano);
            }

            Console.WriteLine();
            Console.WriteLine("Výpis");
            Console.WriteLine();

            for (int i = cisla.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(cisla[i]);
            }

            //vypíšeme součet všech
            Console.WriteLine();

            int soucet = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                soucet += cisla[i];
            }
            Console.WriteLine("Součet zadaných čísel je {0}.", soucet);

            //výpis lichých
            for (int i = 0; i < cisla.Length; i++)
            {
                if (cisla[i] % 2 == 1)
                    Console.WriteLine(cisla[i]);
            }
        }
    }
}