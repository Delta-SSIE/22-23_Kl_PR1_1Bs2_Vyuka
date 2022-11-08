namespace _03_While_07_Kdy_padne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int hod;
            int pocet = 0;

            //while (hod != 6)
            //{
            //    //házej kostkou, dokud nepadne šestka,
            //    hod = rnd.Next(1, 7);
            //    Console.WriteLine(hod);
            //    pocet++;
            //}

            do
            {
                //házej kostkou, dokud nepadne šestka,
                hod = rnd.Next(1, 7);
                Console.WriteLine(hod);
                pocet++;
            }
            while (hod != 6);

            Console.WriteLine("Musel jsem hodit {0}-krát", pocet);
        }
    }
}