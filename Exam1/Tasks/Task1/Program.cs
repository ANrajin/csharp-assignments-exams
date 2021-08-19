using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = ConvertTime("12:30 pm");
            Console.WriteLine(result);

            //DateTime dt = DateTime.Parse("12:30 pm");

            //DateTime dt = DateTime.Parse("1:30 pm");

            //DateTime dt = DateTime.Parse("8:30 am");

            //Console.WriteLine(dt);

            //string convertedDt = dt.ToString("H:MM");
            //convertedDt = dt.ToString("HH:mm");
            //convertedDt = dt.ToString("H:mm");

            //Console.WriteLine(convertedDt);
        }

        public static string ConvertTime(string twelveHourFormat)
        {
            DateTime dt = DateTime.Parse(twelveHourFormat);
            string convertedDT = dt.ToString("H:mm");

            return convertedDT;
        }
    }
}
