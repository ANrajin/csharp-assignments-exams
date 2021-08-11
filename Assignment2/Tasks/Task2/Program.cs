using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = StringValue("Hello World");
            Console.WriteLine(result);
        }

        public static int StringValue(string aText)
        {
            var result = 0;

            for (var i = 0; i < aText.Length; i++)
            {
                result += Convert.ToInt32(aText[i]);
            }

            return result;
        }
    }
}
