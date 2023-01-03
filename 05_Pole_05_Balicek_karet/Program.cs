using System.Diagnostics;

namespace _05_Pole_05_Balicek_karet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] barvy = { "Červené", "Kule", "Žaludy", "Zelené" };
            //string[] vysky = { "Sedma", "Osma", "Devítka", "Desítka", "Spodek", "Vršek", "Král", "Eso" };
            int pocet = 1000;
            string[] barvy = new string[pocet];
            string[] vysky = new string[pocet];
            for (int i = 0; i < pocet; i++)
            {
                barvy[i] = vysky[i] = ((char)i).ToString();
            }

            string[] balicek = new string[barvy.Length * vysky.Length];

            int pristiPozice = 0;
            for (int i = 0; i < barvy.Length; i++)
            {
                for (int j = 0; j < vysky.Length; j++)
                {
                    string karta = barvy[i] + " - " + vysky[j];
                    //balicek[i * 8 + j] = karta;
                    balicek[pristiPozice] = karta;
                    pristiPozice++;
                }
            }

            //Console.WriteLine("Výpis balíčku:");
            //Console.WriteLine();
            //for (int i = 0; i < balicek.Length; i++)
            //{
            //    Console.WriteLine(balicek[i]);
            //}

            //náhodné karty

            //Console.WriteLine();
            //Console.WriteLine("Náhodné karty:");

            Random rnd = new Random();
            //for (int i = 0; i < 16; i++)
            //{
            //    //vymyslím náhodný index
            //    int index = rnd.Next(balicek.Length);

            //    //vyndám z balíčku kartu na tom indexu
            //    Console.WriteLine(balicek[index]);
            //}

            Stopwatch stopky = new Stopwatch();
            stopky.Start();
            //zamíchání balíčku - s pamatováním

            //vyjmu náhodnou kartu z balíčku, podívám se, jestli v cílovému už je a když není, tak ji dám na příští pozici.
            //dělám, dokud není cílový balíček plný
            //string[] zamichano = new string[balicek.Length];
            ////int[] pouziteIndexy = new int[balicek.Length];
            //bool[] pouziteIndexy = new bool[balicek.Length];

            //int pristiIndex = 0;
            //while (pristiIndex < balicek.Length)
            //{
            //    int nahodnyIndex = rnd.Next(balicek.Length);
            //    string karta = balicek[nahodnyIndex];

            //    //zjistím, jestli tuhle kartu už mám
            //    bool kartaTamJe = pouziteIndexy[nahodnyIndex];
            //    //bool kartaTamJe = false;
            //    //for(int i = 0; i < pristiIndex; i++)
            //    //{
            //    //    //if (zamichano[i] == karta)
            //    //    if (pouziteIndexy[i] == nahodnyIndex)
            //    //    {
            //    //        kartaTamJe = true;
            //    //        break;
            //    //    }
            //    //}

            //    //když tam ještě karta není, tak ji tam dej a zvyš pristiIndex
            //    if (!kartaTamJe)
            //    {
            //        zamichano[pristiIndex] = karta;
            //        //pouziteIndexy[pristiIndex] = nahodnyIndex;
            //        pouziteIndexy[nahodnyIndex] = true;
            //        pristiIndex++;
            //    }
            //}
            
            // vytvoř kopii
            string[] zamichano = new string[balicek.Length];
            for (int i = 0; i < balicek.Length; i++)
            {
                zamichano[i] = balicek[i];
            }

            int ukazatel = zamichano.Length - 1;
            while (ukazatel > 0)
            {
                int nahodnyIndex = rnd.Next(ukazatel + 1);

                //prohodit kartu na ukazateli a nahodne pozici
                string temp = zamichano[ukazatel];
                zamichano[ukazatel] = zamichano[nahodnyIndex];
                zamichano[nahodnyIndex] = temp;

                ukazatel--;
            }
            //zamichano.OrderBy(x => rnd.NextDouble());


            stopky.Stop();
            Console.WriteLine("Čas míchání: " + stopky.ElapsedMilliseconds);

            //Console.WriteLine();
            //Console.WriteLine("Výpis zamíchaného balíčku:");
            //for (int i = 0; i < zamichano.Length; i++)
            //{
            //    Console.WriteLine(zamichano[i]);
            //}
        }
    }
}