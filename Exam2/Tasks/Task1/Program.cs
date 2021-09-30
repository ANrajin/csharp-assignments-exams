using System;

namespace Task1
{
    public class Program
    {
        public delegate string Converter(DateTime time);

        static void Main(string[] args)
        {
            var result = Formatter((d) => $"%{d.Date.Day}%");
            Console.WriteLine(result);
        }

        public static string Formatter(Converter converter)
        {
            return converter(DateTime.Now);
        }
    }
}
