using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = IsPrime(19);
            Console.WriteLine(result);

            Console.WriteLine(IsPrime(15));
            Console.WriteLine(IsPrime(5));
            Console.WriteLine(IsPrime(12));
            Console.WriteLine(IsPrime(23));
            Console.WriteLine(IsPrime(20));
            Console.WriteLine(IsPrime(33));
            Console.WriteLine(IsPrime(133));
        }

        public static bool IsPrime(int number)
        {
            if (number >= 2)
            {

                for (var i = 2; i <= number/2; i++)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
