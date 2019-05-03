using MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData
{
    public class ObjectRepo : IObjectRepo
    {
        /// <summary>
        /// Id is auto-incremented
        /// </summary>
        /// <param name="person"></param>
        public int Add(Person person)
        {
            var last = People.PeopleList.LastOrDefault();
            if (last != null)
            {
                person.Id = last.Id + 1;
            }
            else
            {
                person.Id = 1;
            }
            People.PeopleList.Add(person);
            return person.Id;
        }
        public bool Delete(int id)
        {
            var item = GetPerson(id);
            if (item != null)
            {
                People.PeopleList.Remove(item);
                return true;
            }
            else
                return false;
        }
        public bool Update(Person person)
        {
            if (person==null)
            {
                return false;
            }
            var item = GetPerson(person.Id);
            if (item != null)
            {
                item = person;               
                return true;
            }
            else
                return false;
        }
        public List<Person> GetList()
        {
            return People.PeopleList;
        }
        public Person GetFirstPerson()
        {
            var query = from p in People.PeopleList
                        select p;
            return query.FirstOrDefault();

            //return People.PeopleList.FirstOrDefault();
        }
        public Person GetPerson(int id)
        {
            //var query = from p in People.PeopleList
            //            where p.Id == id
            //            select p;
            //return query.FirstOrDefault();

            //return (from p in People.PeopleList
            //        where p.Id == id
            //        select p).FirstOrDefault();

            return People.PeopleList
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

    }
}
