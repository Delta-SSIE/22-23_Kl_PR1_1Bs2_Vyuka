namespace _05_Pole_03_Nakup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetPolozek = 3;

            string[] nazvy = new string[pocetPolozek];
            double[] ceny = new double[pocetPolozek];
            int[] kusy = new int[pocetPolozek];

            for (int i = 0; i < pocetPolozek; i++)
            {
                Console.WriteLine("{0}. položka:", i + 1);
                
                Console.Write("Název: ");
                nazvy[i] = Console.ReadLine();

                Console.Write("Cena za kus: ");
                ceny[i] = double.Parse(Console.ReadLine());

                Console.Write("Počet kusů: ");
                kusy[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------");
            double celkem = 0;
            for (int i = 0; i < pocetPolozek; i++)
            {
                double cenaPolozky = kusy[i] * ceny[i];
                celkem += cenaPolozky;
                Console.WriteLine($"{nazvy[i]}: {kusy[i]} kusů po {ceny[i]:0.00} Kč, celkem {cenaPolozky:0.00} Kč");
            }
            Console.WriteLine("--------------");
            Console.WriteLine("Celkem: {0:0.00} Kč", celkem);
        }
    }
}