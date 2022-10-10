namespace _03_Podm_030_Delidlo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jaký je dělenec: ");
            string nacteno1 = Console.ReadLine();
            int delenec = int.Parse(nacteno1);

            Console.Write("Jaký je dělitel: ");
            string nacteno2 = Console.ReadLine();
            int delitel = int.Parse(nacteno2);

            //if (delitel == 0)
            //{
            //    Console.WriteLine("Nulou se nedělí, ty troubo!");
            //}
            //else
            //{
            //    int podil = delenec / delitel;
            //    int zbytek = delenec % delitel;
            //    Console.WriteLine($"Podíl {delenec} / {delitel} je {podil}, zbytek je {zbytek}.");
            //}

            if (delitel != 0)
            {
                int podil = delenec / delitel;
                int zbytek = delenec % delitel;
                Console.WriteLine($"Podíl {delenec} / {delitel} je {podil}, zbytek je {zbytek}.");
            }
            else
            {
                Console.WriteLine("Nulou se nedělí, ty troubo!");
            }
        }
    }
}