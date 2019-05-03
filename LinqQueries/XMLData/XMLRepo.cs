using MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace XMLData
{
    public class XMLRepo : IObjectRepo
    {
        const string path = "People.xml";

        public int Add(Person person)
        {
            int? id = GetList()
                .Select(p => p.Id)
                .OrderByDescending(p => p)
                .FirstOrDefault();
            var xd = XDocument.Load(path);
            XElement element = new XElement(nameof(Person),
                new XAttribute(nameof(Person.Id), id == null ? "1" : (id + 1).ToString()),
                new XAttribute(nameof(Person.Name), person.Name),
                new XAttribute(nameof(Person.LastName), person.LastName),
                new XAttribute(nameof(Person.BirthDate), person.BirthDate.ToShortDateString()),
                new XAttribute(nameof(Person.Weight), person.Weight.ToString()),
                new XAttribute(nameof(Person.Height), person.Height.ToString())
            );
            xd.Element(nameof(People)).Add(element);
            xd.Save(path);
            return Convert.ToInt32(element.Attribute(nameof(Person.Id)).Value);
        }

        public bool Delete(int id)
        {
            var item = GetPerson(id);
            if (item != null)          
            {
                var xd = XDocument.Load(path);
                string Id = id.ToString();
                var selected = from node in xd.Descendants("Person")
                        let attr = node.Attribute("Id")
                        where attr != null && attr.Value == Id
                        select node;
                selected.Remove();
                xd.Save(path);
                return true;
            }
            else
                return false;
        }

        public List<Person> GetList()
        {
            List<Person> result = new List<Person>();
            var xd = XDocument.Load(path);
            var tempList = xd.Element("People").Elements("Person").ToList();

            tempList.ForEach(u =>
            {
                Person person = new Person
                {
                    Id = int.Parse(u.Attribute("Id").Value),
                    Name = u.Attribute("Name").Value.ToString(),
                    LastName = u.Attribute("LastName").Value.ToString(),
                    BirthDate = Convert.ToDateTime(u.Attribute("BirthDate").Value),
                    Height = int.Parse(u.Attribute("Height").Value),
                    Weight = int.Parse(u.Attribute("Weight").Value)
                };
                result.Add(person);
            });
            return result;
        }

        public Person GetPerson(int id)
        {
            return GetList().Where(p => p.Id == id).FirstOrDefault(); ;
        }

        public bool Update(Person person)
        {
           
            if (person!=null)
            {
                var xd = XDocument.Load(path);
                string Id = person.Id.ToString();
                var selected = from node in xd.Descendants("Person")
                        let attr = node.Attribute("Id")
                        where attr != null && attr.Value == Id
                        select node;
                foreach (XElement updatedPerson in selected)
                {
                    updatedPerson.Attribute("Name").Value = $"{person.Name}";
                    updatedPerson.Attribute("LastName").Value = $"{person.LastName}";
                    updatedPerson.Attribute("BirthDate").Value = $"{person.BirthDate}";
                    updatedPerson.Attribute("Height").Value = $"{person.Height}";
                    updatedPerson.Attribute("Weight").Value = $"{person.Weight}";
                }
                xd.Save(path);
                return true;
            }
            return false;
        }           
            
    }
}
