using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public  class PersonService
    {
        public Person[] Person()
        {
            return new Person[]
            {
                new Person { Id = 1, Name ="Semed", Surname = "Huseynov" },
                new Person { Id = 2, Name ="Tunzale", Surname = "Memmedova" },
                new Person { Id = 3, Name ="Besir", Surname = "Temirli" }
            };

        }
    }
}
