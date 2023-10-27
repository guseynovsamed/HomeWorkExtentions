using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWorkPraktikiExtentions.Helpers.Extentions
{
    public static class BaseExtentions
    {
        public static void ShowNum(this int num , int num2)
        {
            Console.WriteLine(num + num2);

        }


        public static int SumOfNum(this int number , int number2)
        {
            return number + number2;
        }

        public static string ShowText(this string str, string text)
        {
            return str + text;
        }


        public static bool CheckDigitForStr(this string str)
        {
            var result = Regex.IsMatch(str, @"\d");

            return result;

        }

        public static bool CheckEmail(this string str)
        {
            var result = Regex.IsMatch(str, "@");

            return result;

        }


        public static bool CheckStr(this string str , string pattern)
        {
            var result = Regex.IsMatch(str, pattern);

            return result;

        }

        public static int FindFactorial(this int number)
        {
            int result = 1;

            for(int i = 1; i <= number; i++)
            {
                 result *= i;
            }
            return result;
        }

        public static bool CheckEmailAndPassword( this string str , string pattern )
        {
            return Regex.IsMatch(str, pattern);

        }

        public static double PowOfNumber(this double number , double pow)
        {
            return Math.Pow(number, pow);

        }


        public static bool IsConvertStringToNumber(this string str)
        {
            return int .TryParse(str, out var result);
        }
         
    }
}
