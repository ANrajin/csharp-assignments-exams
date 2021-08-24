using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = ConvertTime("12:00 am");
            Console.WriteLine(result);
        }

        public static string ConvertTime(string twelveHourFormat)
        {
            string[] x = twelveHourFormat.Split(':');
            string[] y = x[1].Split();

            string t;

            if (y[1] == "am")
            {
                t = amTime(Convert.ToInt32(x[0]));
            }
            else
            {
                t = pmTime(Convert.ToInt32(x[0]));
            }

            return $"{t}:{y[0]}";
        }

        public static string amTime(int baseTime)
        {
            var t = 12;

            if(baseTime == t)
            {
                t -= baseTime;
                return t.ToString();
            }
            else
            {
                return baseTime.ToString();
            }
        }

        public static string pmTime(int baseTime)
        {
            var t = 12;

            if (baseTime == t)
            {
                return baseTime.ToString();
            }
            else
            {
                t += baseTime;
                return t.ToString();
            }
        }
    }
}
