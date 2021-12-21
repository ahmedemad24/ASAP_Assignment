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
    public class AddressController : ControllerBase
    {
        private readonly IAddress _context;

        public AddressController(IAddress context)
        {
            _context = context; 
        }
        // GET: api/<AddresssController>
        [HttpGet]
        public IEnumerable<Address> Get()
        {
            return _context.GetAllAddresses();
        }

        // GET: api/<GetByPersonID>
        [HttpGet("{person_id}")]
        public IEnumerable<Address> GetAdressPerson(int person_id)
        {
            return _context.GetAllAddressesByPersonID(person_id);
        }

        // POST api/<AddresssController>
        [HttpPost]
        public Address Post(Address Address)
        {
            _context.CreateAddress(Address);
            return Address;
        }

        // PUT api/<AddresssController>/5
        [HttpPut("{id}")]
        public Address Put(int id, int person_id, Address Address)
        {
            _context.EditAddress(id, person_id, Address);
            return Address;
        }

        // DELETE api/<AddresssController>/5
        [HttpDelete("{id}/{person_id}")]
        public void Delete(int id, int person_id)
        {
            _context.DeleteAddress(id, person_id);
        }
    }
}
