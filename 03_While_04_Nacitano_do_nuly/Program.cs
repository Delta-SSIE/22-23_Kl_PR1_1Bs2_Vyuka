namespace _03_While_04_Nacitano_do_nuly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej čísla, já je budu sčítat, nula zadávání ukončí.");

            int suma = 0;

            int cislo = 1;

            while (cislo != 0)
            {
                Console.WriteLine("Zadej číslo:");
                cislo = int.Parse(Console.ReadLine());
                suma += cislo;
            }

            Console.WriteLine($"Konec programu, součet všech čísel byl {suma}.");
        }
    }
}