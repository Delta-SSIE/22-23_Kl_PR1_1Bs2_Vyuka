namespace _02_Podm_04_Bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool jeZima = false;
            bool masPenize = true;

            if (jeZima) //v kulatých závorkách podmínky musí vždycky být bool
                Console.WriteLine("Vem si svetr");

            //jdi ven když buď má peníze nebo není zima
            if (masPenize || !jeZima) 
            { 
                Console.WriteLine("Jdi ven");
            }
            else
            {
                Console.WriteLine("Nikam nechoď");
            }


            if (!masPenize && jeZima) //totéž v negaci
            {
                Console.WriteLine("Nikam nechoď");
            }
            else
            {
                Console.WriteLine("Jdi ven");
            }


        }
    }
}