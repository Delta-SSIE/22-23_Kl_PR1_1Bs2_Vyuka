namespace _05_Pole_04_Vyhledavani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cisla = new int[] { -11, 0, 5, -12, 13, 24, 19, 13, -17 };

            int hledane = int.Parse(Console.ReadLine());

            //bool naselJsem = false;
            int index = -1;

            for (int i = 0; i < cisla.Length; i++)
            {
                int cislo = cisla[i];
                if (cislo == hledane)
                {
                    index = i;
                    break;
                }
            }

            if (index > -1)
                Console.WriteLine("Hledané číslo v poli je na pozici {0}.", index);
            else
                Console.WriteLine("Hledané číslo v poli není.");

        }
    }
}