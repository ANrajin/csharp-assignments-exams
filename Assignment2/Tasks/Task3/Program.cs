using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = LargeSubtraction("987654321987654321987654321", "123456789123456789123456789");
            Console.WriteLine(result);

            //var str1 = "4873";
            //var str2 = "375";

            //var str1Len = str1.Length;

            //int[] arr1 = new int[str1Len];
            //int[] arr2 = new int[str1Len];

            //if (str2.Length < str1Len)
            //{
            //    str2 = str2.PadLeft(str1Len, '0');
            //}

            //for (var i = str1Len - 1; i >= 0; i--)
            //{
            //    arr1[i] = str1[i] - '0';
            //    arr2[i] = str2[i] - '0';
            //}

            //string result = string.Empty;

            //for (var i = arr1.Length - 1; i >= 0; i--)
            //{
            //    if (arr2[i] > arr1[i])
            //    {
            //        arr1[i] = (arr1[i] + 10) - arr2[i];
            //        arr1[i - 1] = arr1[i - 1] - 1;
            //    }
            //    else
            //    {
            //        arr1[i] = arr1[i] - arr2[i];
            //    }
            //}

            //for (var i = 0; i < arr1.Length; i++)
            //{
            //    result += arr1[i].ToString();
            //}

            //Console.WriteLine(result);
        }

        public static string LargeSubtraction(string a, string b)
        {
            var str1 = a;
            var str2 = b;

            var str1Len = str1.Length;
            string result = string.Empty;

            int[] arr1 = new int[str1Len];
            int[] arr2 = new int[str1Len];


            if (str2.Length < str1Len)
            {
                str2 = str2.PadLeft(str1Len, '0');
            }


            for (var i = str1Len - 1; i >= 0; i--)
            {
                arr1[i] = str1[i] - '0';
                arr2[i] = str2[i] - '0';
            }


            for (var i = arr1.Length - 1; i >= 0; i--)
            {
                if (arr2[i] > arr1[i])
                {
                    arr1[i] = (arr1[i] + 10) - arr2[i];
                    arr1[i - 1] = arr1[i - 1] - 1;
                }
                else
                {
                    arr1[i] = arr1[i] - arr2[i];
                }
            }


            for (var i = 0; i < arr1.Length; i++)
            {
                result += arr1[i].ToString();
            }


            return result;
        }
    }
}
