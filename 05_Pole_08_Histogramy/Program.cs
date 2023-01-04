namespace _05_Pole_08_Histogramy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] hodnoty = { 1, 3, 2, 4, 7, 12, 4 };
            char symbol = '#';

            for (int index = 0; index < hodnoty.Length; index++)
            {
                Console.Write(index + ": ");
                Console.WriteLine("".PadRight(hodnoty[index], symbol));
            }

            Console.WriteLine();

            int[] hodnoty2 = { 100, 300, 200, 400, 700, 1200, 400 };
            int delkaRadky = 80;

            int max = 0;
            for (int index = 0; index < hodnoty.Length; index++)
            {
                if (hodnoty2[index] > max)
                    max = hodnoty2[index];
            }

            int maxPocetSymbolu = delkaRadky - 4; // počet znaků pro záhlaví řádky
            double faktor = ((double)max) / maxPocetSymbolu;

            for (int index = 0; index < hodnoty2.Length; index++)
            {
                Console.Write(index + ": ");

                int pocetSymbolu = (int)Math.Round(hodnoty2[index] / faktor);
                Console.WriteLine("".PadRight(pocetSymbolu, symbol));
            }


        }
    }
}