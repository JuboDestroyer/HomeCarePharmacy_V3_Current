using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCarePharmacy_V3.Shared.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }

    }
}
