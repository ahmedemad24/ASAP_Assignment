using ASAP_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASAP_Assignment.Services
{
    public class AddressService : IAddress
    {
        ASAP_DBContext db = new ASAP_DBContext();
        public Address CreateAddress(Address address)
        {
            db.Addresses.Add(address);
            db.SaveChanges();
            return address;
        }

        public void DeleteAddress(int id, int person_id)
        {
            var address = db.Addresses.Where(e => e.AddressId == id && e.PersonId == person_id).FirstOrDefault();
            db.Addresses.Remove(address);
            db.SaveChanges();
        }

        public Address EditAddress(int id, int person_id, Address address)
        {
            var editAddress = db.Addresses.Where(e => e.AddressId == id && e.PersonId == address.PersonId).FirstOrDefault();
            editAddress.Location = address.Location;
            db.SaveChanges();
            return address;
        }

        public List<Address> GetAllAddresses()
        {
            return db.Addresses.ToList();
        }

        public List<Address> GetAllAddressesByPersonID(int id)
        {
            return db.Addresses.Where(e => e.PersonId == id).ToList();
        }

        public Address GetOneAddress(int id)
        {
            return db.Addresses.Find(id);
        }
    }
}
