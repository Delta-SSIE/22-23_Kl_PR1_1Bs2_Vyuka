using System;

namespace _04_For_06_Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string otevrenyText = "UTOK ZACNE VE 3:05 RANO U SEVERNI BRANY!";
            string sifrovyText = "";
            int klic = 52;


            //úprava klíče
            klic %= 26; //zajistím, že klíč bude mezi 26 a 26

            //pro každý znak
            for (int i = 0; i < otevrenyText.Length; i++)
            {
                char znak = otevrenyText[i];

                if (znak >= 'A' && znak <= 'Z')
                {
                    //převést na číslo
                    int cisloZnaku = znak; // protože char je vlastně číslo, převede se automaticky

                    //přičíst klíč
                    cisloZnaku += klic;

                    if (cisloZnaku > 90)
                        cisloZnaku -= 26;
                    else if (cisloZnaku < 65)
                        cisloZnaku += 26;

                    //převést zpět na znak
                    char novyZnak = (char)cisloZnaku;

                    // --vypsat
                    // přidat k sifrovemu textu
                    sifrovyText += novyZnak;
                }
                else
                {
                    sifrovyText += znak;
                }
            }

            //vypsat sifrovy text
            Console.WriteLine(sifrovyText);
        }
    }
}