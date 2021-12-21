using System;
using System.Collections.Generic;

#nullable disable

namespace ASAP_Assignment.Models
{
    public partial class Person
    {
        public Person()
        {
            Addresses = new HashSet<Address>();
        }

        public int PersonId { get; set; }
        public string PersonName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
