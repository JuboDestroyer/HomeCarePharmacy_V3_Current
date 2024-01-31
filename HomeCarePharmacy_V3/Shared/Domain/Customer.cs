using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCarePharmacy_V3.Shared.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PhoneNumber { get; set; }
        public string? Email { get; set; }

    }
}
