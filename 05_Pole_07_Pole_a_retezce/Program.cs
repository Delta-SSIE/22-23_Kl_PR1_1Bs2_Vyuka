namespace _05_Pole_07_Pole_a_retezce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lide = { "Hynek", "Vilém", "Jarmila" };
            Console.WriteLine(string.Join(", ", lide)); //spojí prvky pole "lepidlem"

            string text = "onAir&onWire&deaf";
            string[] parts = text.Split('&');
            for (int i = 0; i < parts.Length; i++)
            {
                Console.WriteLine(parts[i]);
            }


            string veta = "řekněte mi nějakou větu";
            //chci ji vypsat pozpatku
            string[] slova = veta.Split(' ');
            for (int i = slova.Length - 1; i > -1; i--)
            {
                Console.Write(slova[i] + " ");
            }
        }
    }
}