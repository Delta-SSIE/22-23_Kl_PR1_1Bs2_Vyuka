namespace _05_Pole_09_Pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = 100000; //pocet hodů
            int steny = 4; //pocet sten
            int horniMez = steny + 1;

            int[] pocty = new int[horniMez]; //abych mohl uložit i 6 - počítadla pro počty hodů

            for (int i = 0; i < n; i++)
            {
                int hod = rnd.Next(1, horniMez);
                pocty[hod]++;
            }

            for (int i = 1; i < pocty.Length; i++)
            {
                double pst = ((double)pocty[i]) / n * 100;
                Console.WriteLine($"{i}: {pocty[i]} - {pst:0.0} %");
            }
        }
    }
}