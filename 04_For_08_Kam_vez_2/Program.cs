namespace _04_For_08_Kam_vez_2
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


            int cisloRadkuFigury = radekFigury - '1';
            int cisloSloupceFigury = sloupecFigury - 'A';

            //vykreslím šachovnici
            for (int y = 7; y >= 0; y--)
            {
                for (int x = 0; x < 8; x++)
                {
                    if ((x+y) % 2 == 0)
                        Console.BackgroundColor = ConsoleColor.Black;
                    else
                        Console.BackgroundColor = ConsoleColor.White;

                    if (y == cisloRadkuFigury && x == cisloSloupceFigury)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("R ");
                    }
                    else if (y == cisloRadkuFigury || x == cisloSloupceFigury)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("# ");
                    }
                    else
                    { 
                        Console.Write("  ");
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}