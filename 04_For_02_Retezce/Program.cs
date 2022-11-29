using System;

namespace _04_For_02_Retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string veta = "Příliš žluťoučký kůň úpěl ďábelské ódy.";
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    Console.WriteLine(veta[i]);
            //}


            //vypis obracene

            //for (int i = veta.Length - 1; i > -1; i--)
            //{
            //    Console.Write(veta[i]);
            //}


            //obraceny text v retezci

            //string obracene = string.Empty;
            //for (int i = veta.Length - 1; i > -1; i--)
            //{
            //    obracene += veta[i];
            //}
            //Console.WriteLine(obracene);


            //vyhazim mezery
            //string bezMezer = string.Empty;
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    char znak = veta[i];
            //    if (znak != ' ')
            //        bezMezer += znak;
            //}
            //Console.WriteLine(bezMezer);


            //oddelovac za kazdym pismenem
            //char oddelovac = '|';
            //string sOddelovaci = string.Empty;
            //for (int i = 0; i < veta.Length; i++)
            //{
            //    char znak = veta[i];
            //    sOddelovaci += znak;
            //    sOddelovaci += oddelovac;
            //}

            //Console.WriteLine(sOddelovaci);

            string vstup = "Every Day Is a Holiday";

            //vypsat jen velá písmena
            //for (int i = 0; i < vstup.Length; i++)
            //{
            //    char znak = vstup[i];
            //    int kodZnaku = (int)znak;
            //    Console.WriteLine(znak + ": " + kodZnaku);
            //}

            for (int i = 0; i < vstup.Length; i++)
            {
                char znak = vstup[i];
                if (znak >= 65 && znak <= 90)
                    Console.Write(znak);
            }

        }
    }
}