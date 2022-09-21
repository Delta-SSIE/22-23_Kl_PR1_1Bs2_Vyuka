namespace _01_Uvod_04_promenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alokuji paměť - vyhradím ji - pro řetězec a rovnou do promněnné uložím
            string jmeno = "Karel";

            Console.WriteLine(jmeno);

            //je to proměnná - hodnotu lze změnit
            jmeno = "Františka";
            Console.WriteLine(jmeno);


            //někdy chci paměť alokovat ale neuložit - jen deklaruji
            //pak nepíšu = a hodnotu
            string mesto; //říkám "bude existovat proměnná město, ale nic v ní zatím nebude"
            //Console.WriteLine(mesto); //nelze, neinicializováno

            mesto = "Brno";
            Console.WriteLine(mesto);

            //pocet = "deset"; //nelze, pokouším se použít nedeklarovanou proměnnou
        }
    }
}