using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_002
{
    internal class MyMath
    {
        public static int Calc_ggT (int a, int b)
        {

            //int z;

            //while (b != 0)
            //{
            //z = a % b;
            //a = b;
            //b = z;
            //}
            //return a;
            if (b == 0)
            {
                return a;
            }
            return Calc_ggT(b, a % b);
        }


        public static int Calc_kgV (int a, int b)
        {

            return (a * b) / Calc_ggT(a, b);

        }
        public static int ReadInt()
        {
            int number;
            do
            {
                Console.Write("Bitte geben Sie eine positive ganze Zahl ein: ");
                number = int.Parse(Console.ReadLine());
            } 
            while (number <= 0);
            return number;
        }
        public static void ShowResult(string type, int a, int b, int result)
        {
            if (type == "ggT")
            {
                Console.WriteLine($"ggT von {a} und {b} ist {result}");
            }
            else if (type == "kgV")
            {
                Console.WriteLine($"kgV von {a} und {b} ist {result}");
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }



    }
}

