using System;
namespace _03_While_05_Delka_slova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zadej slovo, ukončí mezerou, já ti povím jeho délku.");

            //int delka = 0;
            //string slovo = "";
            //char znak = '\0'; // \0 je obvykle ukončovací znak řetězce v paměti počítače, na klávesnici ho nenajdete.
            //                  // Může tam být cokoli, co není mezera

            //while (znak != ' ')
            //{
            //    znak = Console.ReadKey().KeyChar;
            //    if (znak != ' ')
            //    {
            //        slovo += znak;
            //        delka++;
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Vložené slovo je \"{slovo}\", jeho délka je {delka}.");

            Console.WriteLine("Zadej slovo, ukončí mezerou, já ti povím jeho délku.");

            //int delka = 0;
            string slovo = "";
            char znak = 'a'; // Může tam být cokoli, co je písmeno

            while (char.IsLetter(znak))
            {
                znak = Console.ReadKey().KeyChar;
                if (char.IsLetter(znak))
                {
                    slovo += znak;
                    //delka++;
                }
            }            

            Console.WriteLine();
            Console.WriteLine($"Vložené slovo je \"{slovo}\", jeho délka je {slovo.Length}.");
        }
    }
}