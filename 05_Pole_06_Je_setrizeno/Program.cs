namespace _05_Pole_06_Je_setrizeno
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Zkuste jednu některou deklaraci zakomentovat a jinou odkomentovat
            // váš kód by měl dát pro všechny správnou odpověď

            double[] cisla = { -5, 4.3, 2.7, 6.41, 12 }; //není
            //double[] cisla = { -5, 2.7, 4.3, 6.41, 12 }; //je
            //double[] cisla = { -5, 2.7, 2.7, 4.3, 6.41, 12 }; //je

            bool jeSetrizeno = true;
            for (int i = 0; i < cisla.Length - 1; i++)
            {
                if (cisla[i] > cisla[i+1]) //když je předchůdce větší než následovník
                {
                    jeSetrizeno = false;
                    break;
                }
            }

            if (jeSetrizeno)
                Console.WriteLine("Pole je setřízené");
            else
                Console.WriteLine("Pole není setřízené");

        }
    }
}