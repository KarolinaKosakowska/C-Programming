using System.Collections.Generic;

namespace MockData
{
    public interface IObjectRepo
    {
        int Add(Person person);
        bool Delete(int id);
        List<Person> GetList();
        Person GetPerson(int id);
        bool Update(Person person);
    }
}