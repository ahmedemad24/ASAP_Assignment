using ASAP_Assignment.Models;
using ASAP_Assignment.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASAP_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCorsImplementationPolicy")]
    public class PersonController : ControllerBase
    {

        private readonly IPerson _context;

        public PersonController(IPerson context)
        {
            this._context = context;
        }
        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _context.GetAllPersons();
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _context.GetPerson(id);
        }

        // POST api/<PersonsController>
        [HttpPost]
        public Person Post(Person Person)
        {
            _context.CreatePerson(Person);
            return Person;
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public Person Put(int id, Person Person)
        {
            _context.UpdatePerson(id, Person);
            return Person;
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.DeletePerson(id);
        }
    }
}
