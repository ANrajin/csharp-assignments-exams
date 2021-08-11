using System;
using System.Linq;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = CountVowels("Hellow World");
            Console.WriteLine(result);
        }

        public static int CountVowels(string aText)
        {
            //aText = aText.ToLower();

            char[] vowels = new char[]
            {
                'a',
                'e',
                'i',
                'o',
                'u',
                'A',
                'E',
                'I',
                'O',
                'U'
            };

            int result = 0;

            for (var i = 0; i < aText.Length; i++)
            {
                for (var j = 0; j < vowels.Length; j++)
                {
                    if (aText[i] == vowels[j])
                    {
                        result++;
                    }
                }
            }

            return result;
        }
    }
}
