namespace _01_Uvod_03_Uzivatelsky_vstup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenuješ?");

            //vytvoření proměnné
            //datový_typ název = hodnota (co chci uložit)
            string jmeno = Console.ReadLine();

            //řetězce spojí +
            Console.WriteLine("Ať žije " + jmeno + "!");
        }
    }
}