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
            string bezMezer = string.Empty;
            for (int i = 0; i < veta.Length; i++)
            {
                char znak = veta[i];
                if (znak != ' ')
                    bezMezer += znak;
            }
            Console.WriteLine(bezMezer);


            //oddelovac za kazdym pismenem
            char oddelovac = '|';
            string sOddelovaci = string.Empty;
            for (int i = 0; i < veta.Length; i++)
            {
                char znak = veta[i];
                sOddelovaci += znak;
                sOddelovaci += oddelovac;
            }

            Console.WriteLine(sOddelovaci);
        }
    }
}