namespace _04_For_09_Kam_kral_1
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
                Console.WriteLine("Zadej pozici krále: ");
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


            Console.WriteLine("Král útočí na: ");

            //projdu všech 9 polí kolem krále (včetně) ale prostřední přeskočím
            for (int posunSloupce = -1; posunSloupce < 2; posunSloupce++)
            {
                for (int posunRadku = -1; posunRadku < 2; posunRadku++)
                {
                    if (posunRadku == 0 && posunSloupce == 0)
                        continue;

                    char znakSloupce = (char)(sloupecFigury + posunSloupce);
                    char znakRadku = (char)(radekFigury + posunRadku);
                    
                    if (znakRadku < '1' || znakRadku > '8' || znakSloupce < 'A' || znakSloupce > 'H')
                        continue;

                    Console.WriteLine("" + znakSloupce + znakRadku);
                }
            }
        }
    }
}