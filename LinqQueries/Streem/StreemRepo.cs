using MockData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Streem
{
    public class StreemRepo : IObjectRepo
    {
        const string path = "People.bin";
        public int Add(Person person)
        {            
            using (var fs = new FileStream(path, FileMode.Create))
            {
                var bf = new BinaryFormatter();
                bf.Serialize(fs, person);
            }
            return -1;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            List<Person> result = new List<Person>();
            if (File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open))
                {
                    if (fs.Length > 0)
                    {
                        var bf = new BinaryFormatter();
                        result.Add((Person)bf.Deserialize(fs)); 
                    }
                }
            }
            return result;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
