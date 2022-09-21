namespace _01_Uvod_05_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo = 0;
            Console.WriteLine(cislo);

            cislo = cislo + 5;
            Console.WriteLine(cislo);

            int velke = int.MaxValue; //největší dovolené číslo
            Console.WriteLine(velke);
            velke = velke + 1;
            Console.WriteLine(velke); //nejmenší číslo - došlo k přetečení

            int delenec = 20;
            int delitel = 3;
            int podil = delenec / delitel; //dělím int / int => výsledek je int, celočíselné dělení se zbytkem
            int zbytek = delenec % delitel; // operátor %, nazýváme modulo, znamená zbytek po dělení
            
            //zápis spojováním s řetězci
            Console.WriteLine("Podil " + delenec + " / " + delitel + " je " + podil + ", zbytek je " + zbytek + ".");
            
            //zápis s formátovácím řetězcem
            Console.WriteLine("Podil {0} / {1} je {2}, zbytek je {3}.", delenec, delitel, podil, zbytek);

            //interpolace řetězce - pozor na $ před uvozovkami
            Console.WriteLine($"Podíl {delenec} / {delitel} je {podil}, zbytek je {zbytek}.");

            double delenec2 = 20; //desetinné číslo
            double delitel2 = 3;
            double podil2 = delenec2 / delitel2; //dělení s desetinným číslem => výsledek zase desetinné
            Console.WriteLine($"Podíl {delenec2} / {delitel2} je {podil2}.");

            double jineCislo = 1.7; //s tečkou, v kódu vždy desetiiná tečka!
            //double dalsiCislo = 1,7; //chyba, deteinnou čárku nelze

        }
    }
}