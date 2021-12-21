using ASAP_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASAP_Assignment.Services
{
    public class PersonService : IPerson
    {
        ASAP_DBContext db = new ASAP_DBContext();
        public Person CreatePerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return person;
        }

        public void DeletePerson(int id)
        {
            var person = db.People.Where(e => e.PersonId == id).FirstOrDefault();
            db.People.Remove(person);
            db.SaveChanges();
        }

        public List<Person> GetAllPersons()
        {
            return db.People.ToList();
        }

        public Person GetPerson(int id)
        {
            return db.People.Find(id);
        }

        public Person UpdatePerson(int id, Person person)
        {
            var editPerson = GetPerson(id);
            editPerson.PersonName = person.PersonName;
            db.SaveChanges();
            return person;
        }
    }
}
