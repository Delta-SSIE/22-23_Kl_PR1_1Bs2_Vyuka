namespace _03_While_09_Prumerny_hod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetSten;
            int pocetHodu;
            string nacteno;
            bool prvniPruchod;

            //načtu počet stěn
            prvniPruchod = true;
            //int pocetSten =  
            do
            {
                if (prvniPruchod)
                    prvniPruchod = false;
                else
                    Console.WriteLine("Chyba formátu");

                Console.WriteLine("Zadej počet stěn kostky: ");
                nacteno = Console.ReadLine();
            }
            while (!int.TryParse(nacteno, out pocetSten) || pocetSten < 2);

            //načtu počet hodů - opakování
            //int pocetHodu =  
            prvniPruchod = true;
            do
            {
                if (prvniPruchod)
                    prvniPruchod = false;
                else
                    Console.WriteLine("Chyba formátu");

                Console.WriteLine("Zadej počet hodů: ");
                nacteno = Console.ReadLine();
            }
            while (!int.TryParse(nacteno, out pocetHodu) || pocetHodu < 1);

            int pokus = 0;
            int soucet = 0;
            Random rnd = new Random();

            while (pokus < pocetHodu)
            {
                soucet += rnd.Next(1, pocetSten + 1);
                pokus++;
            }

            double prumer = ((double)soucet) / pocetHodu;

            Console.WriteLine("Průměrný počet hodů {0}-stěnnou kostkou byl {1}.", pocetSten, prumer);
        }
    }
}