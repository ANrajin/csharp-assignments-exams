using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = BinaryToDecimal("11110101010101010101011");
            Console.WriteLine(result);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            int[] arr = new int[binaryNumber.Length];

            int result = 0;

            for (var i = 0; i < binaryNumber.Length; i++)
            {
                var num = 1;

                for (var j = (binaryNumber.Length - 1); j > i; j--)
                {
                    num *= 2;
                }

                if (binaryNumber[i] == '1')
                    result += 1 * num;
            }

            return result;
        }
    }
}
