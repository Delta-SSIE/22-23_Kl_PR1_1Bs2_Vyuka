namespace _002_Dalsi_writeline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cokoli za dvěma lomítky je tzv. komentář - při kompilaci se přeskočí
            //obvykle v něm vysvětlíme, jak kód funguje
            Console.WriteLine("Ahoj světe!");
            Console.WriteLine("Jsem tu.");

            //prázdné řádky se taky přeskakují

            /* 
             Takhle se dělají víceřádkové komentáře
            ani tohle se nevykoná
            a
            ani
            tohle             
             */

            // blok kódu zakomentuje CTRL-K-C, odkomentuje CTRL-K-U
            Console.Write("A chci něco dělat");
            Console.Write("Nemáš pro mě tip?");

            //Console.WriteLine bez parametru přeskočí řádek
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Je tu nepořádek.");
        }
    }
}