
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork.Helpers.Extentions
{
    internal static class BaseExtentions
    {
        public static bool CheckEmail(this string email)
        {
            bool result = true;
            int count = 0;
            foreach (var item in email)
            {
                if (item == '@')
                {
                    count++;
                }
            }

            if (count > 1 || count == 0)
            {
                result = false;
            }

            return result;

        }

        public static bool CheckSpace(this string email)
        {
            return Regex.IsMatch(email, @"\s");
        }

        public static int MultiplyArray(this int[] numbers )
        {
            int sum = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                sum *= numbers[i];
            }

            return sum;
        }



        public static string GetPersonFullData(this Person person )
        {
            var result = person.Surname + " " + person.Name + " " + person.Id;


            return result;
            
        }
    }
}
