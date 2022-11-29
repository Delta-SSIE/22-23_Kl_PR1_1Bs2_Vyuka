namespace _04_For_03_Ctverec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int strana;
            string vstup;
            do
            {
                Console.WriteLine("Zadej stranu čtverce: ");
                vstup = Console.ReadLine();
            }
            while (!int.TryParse(vstup, out strana) || strana < 0);

            //když strana = 3
            //tak nakreslí
            // ###
            // ###
            // ###

            for (int y = 0; y < strana; y++)
            {
                for (int x = 0; x < strana; x++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
        }
    }
}