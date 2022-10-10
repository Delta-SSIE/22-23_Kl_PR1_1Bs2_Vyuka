namespace _02_Podm_07_Nacteni_klavesy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Máš rád psy? (A/N)");
            string odpoved = Console.ReadLine();

            if (odpoved == "A" || odpoved == "a")
                Console.WriteLine("To je dobře");
            else
                Console.WriteLine("Nechoď mi na oči");

            //char znak = Console.ReadKey().KeyChar;

            //if (znak == 'A' || znak == 'a')
            //    Console.WriteLine("To je dobře");
            //else
            //    Console.WriteLine("Nechoď mi na oči");

        }
    }
}