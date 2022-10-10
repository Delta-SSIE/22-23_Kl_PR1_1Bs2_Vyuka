namespace _02_Podm_06_Prehled
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* jednoduchá podmínka */
            //Console.WriteLine("Zadej číslo: ");
            //string input = Console.ReadLine();
            //int cislo = int.Parse(input);

            //if (cislo < 10)
            //    Console.WriteLine("číslo je malé");

            //Console.WriteLine("Děkuji za použití programu.");



            /* složený příkaz */
            //Console.WriteLine("Zadej číslo: ");
            //string input = Console.ReadLine();
            //int cislo = int.Parse(input);

            //if (cislo < 10)
            //{ 
            //    Console.WriteLine("Číslo je malé");
            //    Console.WriteLine("Ale mně to nevadí");
            //}

            //Console.WriteLine("Děkuji za použití programu.");



            /* úplné větvení */
            //Console.WriteLine("Zadej číslo: ");
            //string input = Console.ReadLine();
            //int cislo = int.Parse(input);

            //if (cislo < 10)
            //{
            //    Console.WriteLine("Číslo je malé");
            //}
            //else if (cislo < 20)
            //{
            //    Console.WriteLine("Číslo je tak akorát");
            //}
            //else if (cislo < 30)
            //{
            //    Console.WriteLine("Číslo je trochu velké");
            //}
            //else
            //{
            //    Console.WriteLine("Číslo je hodně velké");
            //}

            //Console.WriteLine("Děkuji za použití programu.");



            /* naplnění proměnné podle hodnoty */
            //Console.WriteLine("Zadej číslo: ");
            //string input = Console.ReadLine();
            //int cislo = int.Parse(input);

            //string hodnoceni;
            //if (cislo < 10)
            //    hodnoceni = "malé";
            //else
            //    hodnoceni = "velké";

            //Console.WriteLine($"Číslo je {hodnoceni}.");



            /* ternární operátor */
            //Console.WriteLine("Zadej číslo: ");
            //string input = Console.ReadLine();
            //int cislo = int.Parse(input);

            //string hodnoceni = (cislo < 10) ? "malé" : "velké";
            //Console.WriteLine($"Číslo je {hodnoceni}.");



            /* switch */
            //Console.Write("Zadej číslo dne (1-7): ");
            //int cislo = int.Parse(Console.ReadLine());

            //string den;

            //if (cislo == 1)
            //    den = "pondělí";
            //else if (cislo == 2)
            //    den = "úterý";
            //else if (cislo == 3)
            //    den = "středa";
            //else if (cislo == 4)
            //    den = "čtvrtek";
            //else if (cislo == 5)
            //    den = "pátek";
            //else if (cislo == 6)
            //    den = "sobota";
            //else if (cislo == 7)
            //    den = "neděle";
            //else
            //    den = "nějaký divný den";

            //switch (cislo)
            //{
            //    case 1:
            //        den = "pondělí";
            //        break;
            //    case 2:
            //        den = "úterý";
            //        break;
            //    case 3:
            //        den = "středa";
            //        break;
            //    case 4:
            //        den = "čtvrtek";
            //        break;
            //    case 5:
            //        den = "pátek";
            //        break;
            //    case 6:
            //        den = "sobota";
            //        break;
            //    case 7:
            //        den = "neděle";
            //        break;
            //    default:
            //        den = "nějaký divný den";
            //        break;
            //}

            //Console.WriteLine($"Dnes je {den}.");



            /* switch - spojené případy */
            Console.Write("Zadej číslo dne (1-7): ");
            int cislo = int.Parse(Console.ReadLine());

            string typDne;

            switch (cislo)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    typDne = "pracovní den";
                    break;
                case 6:
                case 7:
                    typDne = "víkend";
                    break;
                default:
                    typDne = "asi chyba";
                    break;
            }

            Console.WriteLine($"Den s číslem {cislo} je {typDne}.");

        }
    }
}