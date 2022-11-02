namespace _03_While_06_Maximalni_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já najdu největší, nula zadávání ukončí.");

            int maximum = 0;
            int cislo = 1;

            while (cislo != 0)
            {
                Console.WriteLine("Zadej číslo:");
                cislo = int.Parse(Console.ReadLine());
                if (cislo > maximum)
                    maximum = cislo;
            }

            Console.WriteLine($"Konec programu, největší z čísel bylo {maximum}.");
        }
    }
}