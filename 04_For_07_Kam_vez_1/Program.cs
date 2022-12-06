using System;

namespace _04_For_07_Kam_vez_1
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string vstup;
            char radekFigury = ' ';
            char sloupecFigury = ' ';
            bool jeChyba;

            //načíst (a zkontrolovat)
            do
            {
                jeChyba = false;
                Console.WriteLine("Zadej pozici věže: ");
                vstup = Console.ReadLine().ToUpper();

                //má to dva znaky?
                if (vstup.Length != 2)
                {
                    Console.WriteLine("Chybný formát");
                    jeChyba = true;
                    continue; //běž na koncovou podmínku
                }

                //rozdělit
                sloupecFigury = vstup[0];
                radekFigury = vstup[1];

                if (sloupecFigury < 'A' || sloupecFigury > 'H' || radekFigury < '1' || radekFigury > '8')
                {
                    Console.WriteLine("Chybný formát");
                    jeChyba = true;
                    continue; //běž na koncovou podmínku
                }
            }
            while (jeChyba);
            //teď mám zajištěn platný vstup v obou proměnných


            Console.WriteLine("Vež útočí na: ");
            //projít všechny sloupce a přidat řádek věže
            for (int i = 0; i < 8; i++)
            {
                char znakSloupce = (char)('A' + i);
                if (znakSloupce != sloupecFigury)
                    Console.WriteLine("" + znakSloupce + radekFigury);
            }
            //projít všechny řádky a přidat sloupec věže
            for (int i = 0; i < 8; i++)
            {
                char znakRadku = (char)('1' + i);
                if (znakRadku != radekFigury)
                    Console.WriteLine("" + sloupecFigury + znakRadku);
            }
        }
    }
}