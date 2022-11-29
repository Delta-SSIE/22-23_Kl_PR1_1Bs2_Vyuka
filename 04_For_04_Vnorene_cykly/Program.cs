using System;

namespace _04_For_04_Vnorene_cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        for (int k = 0; k < 8; k++)
            //        {
            //            //Console.WriteLine($"{i}{j}{k}");
            //            string kombinace = "" + i + j + k;
            //            Console.WriteLine(kombinace);
            //        }
            //    }
            //}

            for (int S = 1; S < 10; S++)
            {
                for (int E = 0; E < 10; E++)
                {
                    if (E == S) continue;

                    for (int N = 0; N < 10; N++)
                    {
                    
                        if (N == S || N == E) continue;
                        
                        for (int D = 0; D < 10; D++)
                        {
                            if (D == S || D == E || D == N) continue;

                            for (int M = 1; M < 10; M++)
                            {

                                if (M == S || M == E || M == N || M == D) continue;

                                for (int O = 0; O < 10; O++)
                                {

                                    if (O == S || O == E || O == N || O == D || O == M) continue;

                                    for (int R = 0; R < 10; R++)
                                    {
                                        if (R == S || R == E || R == N || R == D || R == M || R == O) continue;

                                        for (int Y = 0; Y < 10; Y++)
                                        {
                                            if (Y == S || Y== E || Y == N || Y == D || Y == M || Y == O || Y == R) continue;

                                            int send = S * 1_000 + E * 100 + N * 10 + D;
                                            int more = M * 1_000 + O * 100 + R * 10 + E;
                                            int money = M * 10_000 + O * 1_000 + N * 100 + E * 10 + Y;

                                            if (send + more == money)
                                            {
                                                Console.WriteLine($" {S}{E}{N}{D}");
                                                Console.WriteLine($"+{M}{O}{R}{E}");
                                                Console.WriteLine($"{M}{O}{N}{E}{Y}");
                                                Console.WriteLine();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}