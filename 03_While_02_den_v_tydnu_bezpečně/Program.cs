namespace _03_While_02_den_v_tydnu_bezpečně
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;

            while (cislo < 1 || cislo > 7) //dokud nemáš dobré číslo, načítej znovu a znovu
            { 
                Console.Write("Zadej číslo dne (1-7): ");
                cislo = int.Parse(Console.ReadLine());
            }

            string den;

            switch (cislo)
            {
                case 1:
                    den = "pondělí";
                    break;
                case 2:
                    den = "úterý";
                    break;
                case 3:
                    den = "středa";
                    break;
                case 4:
                    den = "čtvrtek";
                    break;
                case 5:
                    den = "pátek";
                    break;
                case 6:
                    den = "sobota";
                    break;
                case 7:
                    den = "neděle";
                    break;
                default:
                    den = "nějaký divný den";
                    break;
            }

            Console.WriteLine($"Dnes je {den}.");

        }
    }
}