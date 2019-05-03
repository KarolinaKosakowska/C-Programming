using MockData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;



namespace JSONData
{
    public class JSONRepo : IObjectRepo
    {
        const string path = "People.json";

        public int Add(Person person)
        {
            var people = GetList();
            int lastId = people != null && people.Count > 0 ? people.Max(a => a.Id) + 1 : 1;
            person.Id = lastId;
            people.Add(person);
            Serialize(people);
            return person.Id;
        }

        public bool Delete(int id)
        {
            var people = GetList();
            var item = people.Where(a => a.Id == id).FirstOrDefault();
            if (item != null)
            {
                people.Remove(item);
                Serialize(people);
                return true;
            }
            return false;
        }

        public List<Person> GetList()
        {
            return JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(path)) ?? new List<Person>();            
        }

        public Person GetPerson(int id)
        {
            return GetList().Where(a => a.Id == id).FirstOrDefault();
        }

        public bool Update(Person person)
        {
            if (person == null)
            {
                return false;
            }     
            Delete(person.Id);
            var people = GetList();
            people.Add(person);            
            Serialize(people);
            return true;
        }
        private void Serialize(List<Person> people)
        {
            string serializedJson = JsonConvert.SerializeObject(people);
            File.WriteAllText(path, JToken.Parse(serializedJson).ToString());
        }
    }
}
