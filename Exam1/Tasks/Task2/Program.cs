using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Rotate("aaabbcc", 2);
            Console.WriteLine(result);
        }

        public static string Rotate(string original, int count)
        {
            var str = original;

            var totalLen = str.Length;

            char lastChar;

            for (var i = 0; i < count; i++)
            {
                lastChar = str[str.Length - 1];

                str = str.Remove(str.Length - 1);

                str = str.PadLeft(totalLen, lastChar);
            }

            return str;
        }
    }
}
