namespace _01_Uvod_06_Nacteni_cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik lidí přijde?");
            //int pocet = Console.ReadLine(); //nelze, readline vždy vrací řetězec, nelze uložit do int
            string nacteno = Console.ReadLine(); //v řetězci nacteno bedu to, co uzivatel napsal
            int pocet = int.Parse(nacteno);

            Console.WriteLine("Přijde k nám {0} lidí na večeři, takže nás tu bude {1}.", pocet, pocet + 2);

            //pozor, s řetězcem dojde ke skládání, nespadne ale bude kecat
            Console.WriteLine("Přijde k nám {0} lidí na večeři, takže nás tu bude {1}.", nacteno, nacteno + 2);

            Console.WriteLine("Kolik je cena?");
            string nactenaCena = Console.ReadLine(); //načtu řetězec od uživatele
            double cena = double.Parse(nactenaCena); //převedu vložený řetězec na desetinné číslo
            double cenaZaOsobu = cena / pocet; //dělím double / int => výsledek bude double
            Console.WriteLine($"Cena za osobu vychází {cenaZaOsobu}.");
        }
    }
}