namespace _01_Uvod_07_Chary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lze uložit i jeden znak
            char znak = 'A';
            Console.WriteLine(znak);

            char dalsiZnak = 'h';

            string slovo = "" + znak + dalsiZnak + "oj"; //pozor, bez uvozovek na začátku to bude sčítat hodnoty znaků
            Console.WriteLine(slovo);
        }
    }
}