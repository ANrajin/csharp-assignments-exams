using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Rotate("aaabbcc", 2);
            Console.WriteLine(result);

            //var str = "aaabbcc";
            //var strLen = str.Length - 1;

            //var newStr = str.Remove(strLen);

            //Console.WriteLine(newStr.Remove(strLen-1));

            //var str = "aaabbcc";

            //var totalLen = str.Length;

            //var Len = totalLen - 1;

            //char lastChar = '0';

            //string result = string.Empty;

            //var newStr = string.Empty;

            //for (var i = 0; i < 2; i++)
            //{
            //    lastChar = str[Len];

            //    newStr = str.Remove(Len);

            //    result = newStr.PadLeft(totalLen, lastChar);
            //}

            //Console.WriteLine(result);


        }

        public static string Rotate(string original, int count)
        {
            var str = original;

            var totalLen = original.Length;

            var Len = totalLen - 1;

            char lastChar = '0';

            string result = string.Empty;

            var newStr = string.Empty;

            for (var i = 0; i < count; i++)
            {
                lastChar = str[Len];

                newStr = str.Remove(Len);

                result = newStr.PadLeft(totalLen, lastChar);
            }

            return result;
        }
    }
}
