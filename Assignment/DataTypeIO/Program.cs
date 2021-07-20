using System;

namespace DataTypeIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int Array
            int[] scores = new int[5];

            Console.WriteLine("Insert Five scores:");
            scores[0] = int.Parse(Console.ReadLine());
            scores[1] = int.Parse(Console.ReadLine());
            scores[2] = int.Parse(Console.ReadLine());
            scores[3] = int.Parse(Console.ReadLine());
            scores[4] = int.Parse(Console.ReadLine());


            Console.WriteLine("The elements of int array are:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ", scores[i]);
            }


            //Double
            double[] prices = new double[5];

            Console.WriteLine("\nInsert five price");
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of double array are:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ", prices[i]);
            }

            Console.WriteLine("\nInsert five CGPA");
            //float
            var cgpa = new float[5];
            cgpa[0] = float.Parse(Console.ReadLine());
            cgpa[1] = float.Parse(Console.ReadLine());
            cgpa[2] = float.Parse(Console.ReadLine());
            cgpa[3] = float.Parse(Console.ReadLine());
            cgpa[4] = float.Parse(Console.ReadLine());

            Console.WriteLine("The elements of float array are:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ", cgpa[i]);
            }


            //Decimal
            var numb = new decimal[5];

            Console.WriteLine("\nInsert five Decimal number");
            for (int i = 0; i < numb.Length; i++)
            {
                numb[i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of decimal array are:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ", numb[i]);
            }


            string[] str = new string[5];

            Console.WriteLine("\nInsert five of your friend name");
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            Console.WriteLine("The elements of string array are:");
            Console.WriteLine(string.Join(",", str));


            //long
            long[] numbers = new long[5];

            Console.WriteLine("\nInsert five long number");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }

            Console.WriteLine("The elements of long array are:");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }


            //DateTime
            Console.WriteLine("\nInsert five Dates. YYYY-MM-DD");

            DateTime[] dates = new DateTime[5];

            dates[0] = Convert.ToDateTime(Console.ReadLine());
            dates[1] = Convert.ToDateTime(Console.ReadLine());
            dates[2] = Convert.ToDateTime(Console.ReadLine());
            dates[3] = Convert.ToDateTime(Console.ReadLine());
            dates[4] = Convert.ToDateTime(Console.ReadLine());


            Console.WriteLine("The elements of long array are:");
            for (int i = 0; i < dates.Length; i++)
            {
                Console.WriteLine("{0} ", dates[i].ToShortDateString());
            }


            //Boolean
            bool[] arr = new bool[5];

            Console.WriteLine("\nInsert five boolean. ex: true / false");

            arr[0] = bool.Parse(Console.ReadLine());
            arr[1] = bool.Parse(Console.ReadLine());
            arr[2] = bool.Parse(Console.ReadLine());
            arr[3] = bool.Parse(Console.ReadLine());
            arr[4] = bool.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(",", arr));
        }
    }
}
