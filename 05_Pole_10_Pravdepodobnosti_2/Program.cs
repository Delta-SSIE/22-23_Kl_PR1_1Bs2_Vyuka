namespace _05_Pole_10_Pravdepodobnosti_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int n = 100000; //pocet hodů
            int k = 2; //pocet hodu , které se scitaji (napr 2 = hazim 2 kostkami)
            int steny = 6; //pocet sten
            int dolniMez = k; //nejmenší možný hod k kostkami
            int horniMez = steny * k + 1; //největší možný hod + 1

            int[] pocty = new int[horniMez]; //abych mohl uložit i 6 - počítadla pro počty hodů

            for (int i = 0; i < n; i++)
            {
                int hod = 0;
                for (int j = 0; j < k; j++)
                {
                    hod += rnd.Next(1, steny + 1);
                }                                
                pocty[hod]++;
            }

            for (int i = dolniMez; i < horniMez; i++)
            {
                double pst = ((double)pocty[i]) / n * 100;
                Console.WriteLine($"{i}: {pocty[i]} - {pst:0.0} %");
            }
        }
    }
}