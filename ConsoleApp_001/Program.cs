namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie ist dein Name?");
            string name = Console.ReadLine();


            Console.WriteLine("how many times?");
            int anzahl = 0;

            if (int.TryParse(Console.ReadLine(), out anzahl))
            {
                for (int i = 0; i < anzahl; i++)
                {
                    Console.WriteLine("Hello, World! {0} {1}", name, i);
                    Console.WriteLine($"Hello, World! {name} {i}");

                }
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
            }

            Console.WriteLine("und tschüss");

        }
    }
}
