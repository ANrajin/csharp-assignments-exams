using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = int.IsOdd(4);
            Console.WriteLine(result);
        }

        public static bool IsOdd(int a)
        {
            return (a % 2 != 0);
        }
    }
}
