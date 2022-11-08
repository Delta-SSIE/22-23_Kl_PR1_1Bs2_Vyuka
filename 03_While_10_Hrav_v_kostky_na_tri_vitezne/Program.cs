namespace _03_While_10_Hrav_v_kostky_na_tri_vitezne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int vitezstvi = 3;

            int skore1 = 0;
            int skore2 = 0;
            int kolo = 1;

            while (skore1 < vitezstvi && skore2 < vitezstvi)
            {
                int hod1 = rnd.Next(1, 7);
                int hod2 = rnd.Next(1, 7);

                Console.WriteLine($"{kolo}. kolo");
                Console.WriteLine($"Hra: hráč 1 hází {hod1}: hráč 2 hází {hod2}");

                if (hod1 > hod2)
                {
                    Console.WriteLine($"Vítězí hráč 1");
                    skore1++;
                }
                else if (hod1 < hod2)
                {
                    Console.WriteLine($"Vítězí hráč 2");
                    skore2++;
                }
                else
                {
                    Console.WriteLine("Remíza");
                }

                kolo++;
                Console.WriteLine($"Stav zápasu po {kolo}. kole - {skore1} : {skore2}");
                Console.WriteLine();
            }
            string vitez = skore1 > skore2 ? "Hráč 1" : "Hráč 2";
            Console.WriteLine($"Celkový vítěz je {vitez}.");

        }
    }
}