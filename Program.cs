using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть значення А:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть значення B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть значення модуля Mod:");
            int mod = int.Parse(Console.ReadLine());
            int result = (a + b) % mod;
            Console.WriteLine(string.Format("Результат додавання:\n{0} + {1} mod {2} = {3}", a, b, mod, result));
            Console.ReadLine();
        }
    }
}
