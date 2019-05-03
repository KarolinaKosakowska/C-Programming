using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData
{
    public class People
    {
        public static List<Person> PeopleList = new List<Person>
        {
                new Person
                {
                    Id = 1,
                    Name = "Roman",
                    LastName = "Kowalski" ,
                    BirthDate = new DateTime(1900, 1, 1),
                    Height = 2000,
                    Weight = 80
                },
                new Person
                {
                    Id = 2,
                    Name = "Anna",
                    LastName = "Kowalska" ,
                    BirthDate = new DateTime(1900, 1, 1),
                    Height = 2000,
                    Weight = 80
                },
                new Person
                {
                    Id = 3,
                    Name = "Roman",
                    LastName = "Dmowski" ,
                    BirthDate = new DateTime(1900, 1, 1),
                    Height = 2000,
                    Weight = 80
                },
                new Person
                {
                    Id = 4,
                    Name = "Kazimierz",
                    LastName = "Kowalski" ,
                    BirthDate = new DateTime(1900, 1, 1),
                    Height = 2000,
                    Weight = 80
                },
                new Person
                {
                    Id = 5,
                    Name = "Janiana",
                    LastName = "Nowak" ,
                    BirthDate = new DateTime(1900, 1, 1),
                    Height = 2000,
                    Weight = 80
                },
                new Person
                {
                    Id = 6,
                    Name = "Maria",
                    LastName = "Skłodowska" ,
                    BirthDate = new DateTime(1990, 1, 1),
                    Height = 1000,
                    Weight = 36
                },
                new Person
                {
                    Id = 7,
                    Name = "Emil",
                    LastName = "Groźny" ,
                    BirthDate = new DateTime(1980, 1, 1),
                    Height = 1500,
                    Weight = 30
                },
                new Person
                {
                    Id = 8,
                    Name = "Mirek",
                    LastName = "Stary" ,
                    BirthDate = new DateTime(2000, 11, 1),
                    Height = 1980,
                    Weight = 67
                }
        };
    }
}
