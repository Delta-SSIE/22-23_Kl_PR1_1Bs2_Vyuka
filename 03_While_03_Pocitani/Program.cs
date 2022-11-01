namespace _03_While_03_Pocitani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int pocitadlo = 0;

            //while (pocitadlo <= 100)
            //{
            //    Console.WriteLine(pocitadlo);
            //    //pocitadlo = pocitadlo + 1;
            //    //pocitadlo += 1;
            //    pocitadlo++; //zvyš o jedna
            //}

            int pocitadlo = 100;

            while (pocitadlo >= 0)
            {
                Console.WriteLine(pocitadlo);
                pocitadlo -= 5;
            }
        }
    }
}