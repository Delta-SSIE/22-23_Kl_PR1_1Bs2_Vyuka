namespace _02_Podm_01_Vyber_auta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik to stojí: ");
            string nactenaCena = Console.ReadLine();
            int cena = int.Parse(nactenaCena);

            Console.Write("Kolik na to máš: ");
            string nactenyLimit = Console.ReadLine();
            int limit = int.Parse(nactenyLimit);

            if (cena >= limit)
            {
                Console.WriteLine("Neber to, stejně je to popelnice.");
            }
            else
            {
                Console.WriteLine("Kup to hned!");
            }

            //Console.WriteLine("Pro ukončení stiskni ENTER");
            //Console.ReadLine();
            
            Console.WriteLine("Pro ukončení stiskni libovolnou klávesu");
            Console.ReadKey();
        }
    }
}