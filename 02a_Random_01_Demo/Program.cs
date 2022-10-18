namespace _02a_random_01_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int nahoda = generator.Next(1, 7);
            //1 ...nejnižší, které chci
            //7 ... nejnižší, které už nechci

            Console.WriteLine(nahoda);
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));

            for (int i = 0; i < 50; i++) { 
            int hod = generator.Next(0, 2);
            if (hod == 0)
                Console.WriteLine("Padla panna");
            else
                Console.WriteLine("Padl vorel");
            }

        }
    }
}