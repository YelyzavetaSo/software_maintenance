using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int mod = int.Parse(Console.ReadLine());
            int result = (a + b) % mod;
            Console.WriteLine(string.Format("{0} + {1} mod {2} = {3}", a, b, mod, result));
            Console.ReadLine();

        }
    }
}
