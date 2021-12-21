using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASAP_Assignment.Models;

namespace ASAP_Assignment.Services
{
    public interface IPerson
    {
        List<Person> GetAllPersons();
        Person CreatePerson(Person person);
        Person GetPerson(int id);
        Person UpdatePerson(int id, Person person);
        void DeletePerson(int id);
    }
}
