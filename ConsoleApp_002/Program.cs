namespace ConsoleApp_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = MyMath.ReadInt();
                int y = MyMath.ReadInt();

                int ggtResult = MyMath.Calc_ggT(x, y);
                MyMath.ShowResult("ggT", x, y, ggtResult);

                int kgvResult = MyMath.Calc_kgV(x, y);
                MyMath.ShowResult("kgV", x, y, kgvResult);

                MyMath.Swap(ref x, ref y);
                Console.WriteLine($"Nach dem Vertauschen: x = {x}, y = {y}");

                Console.Write("Möchten Sie eine weitere Berechnung durchführen? (ja/nein): ");
                string weiter = Console.ReadLine().ToLower();
                if (weiter != "ja")
                {
                    break;
                }

            }
        }
    }

}
