namespace _03_While_08_Nacteni_cisla_bezpecne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            string nacteno;
            bool prvniPruchod = true;

            do
            {
                if (prvniPruchod)
                    prvniPruchod = false;
                else
                    Console.WriteLine("Chyba formátu");

                Console.WriteLine("Zadej celé číslo: ");
                nacteno = Console.ReadLine();
            }
            while (!int.TryParse(nacteno, out cislo));

            Console.WriteLine("Zadal jsi {0}.", cislo);
        }
    }
}