using System;
using System.Collections.Generic;

#nullable disable

namespace ASAP_Assignment.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Location { get; set; }
        public int? PersonId { get; set; }

        public virtual Person Person { get; set; }
    }
}
