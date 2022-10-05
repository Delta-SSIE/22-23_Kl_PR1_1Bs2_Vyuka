namespace _02_Podm_02_Vice_vetvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            string hodnota = Console.ReadLine();
            int cislo = int.Parse(hodnota);

            //if (cislo < 3)
            //{
            //    Console.WriteLine($"Číslo {cislo} je malé");
            //}
            //else if (cislo < 7)
            //{
            //    Console.WriteLine($"Číslo {cislo} je tak akorát");
            //}
            //else
            //{
            //    Console.WriteLine($"Číslo {cislo} je velké");
            //}

            string rozhodnuti;
            if (cislo < 3)
            {
                rozhodnuti = "malé";
            }
            else if (cislo < 7)
            {
                rozhodnuti = "tak akorát";
            }
            else
            {
                rozhodnuti = "velké";
            }

            Console.WriteLine($"Číslo {cislo} je {rozhodnuti}");

        }
    }
}