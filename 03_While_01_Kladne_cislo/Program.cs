namespace _03_While_01_Kladne_cislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;

            while (pocet < 2)
            {
                Console.WriteLine("Zadej počet stěn kostky:");
                pocet = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Zadané číslo je {pocet}");
        }
    }
}