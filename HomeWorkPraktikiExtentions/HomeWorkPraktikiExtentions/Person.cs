using HomeWorkPraktikiExtentions.Helpers.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkPraktikiExtentions
{
    internal class Person
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public Person(string email)
        {
            Email = email;

            Console.WriteLine(Email.CheckStr(@"\W"));
        }

      
    }
}
