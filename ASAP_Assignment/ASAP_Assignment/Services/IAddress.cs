using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASAP_Assignment.Models;

namespace ASAP_Assignment.Services
{
    public interface IAddress
    {
        List<Address> GetAllAddresses();
        List<Address> GetAllAddressesByPersonID(int id);
        Address CreateAddress(Address address);
        Address GetOneAddress(int id);
        Address EditAddress(int id, int person_id, Address address);
        void DeleteAddress(int id, int person_id);
    }
}
