namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            string name = Console.ReadLine();
            Console.WriteLine("Hallo zum  ersten {0}", name);
            Console.WriteLine($"Hallo zum zweiten {name}");

            int anzahl;
            Console.WriteLine(" wie viele mal?");
            string strAnzahl = Console.ReadLine(); 
            anzahl = int.Parse(strAnzahl);

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"zum {i}. mal");
            }

        }
    }
}
