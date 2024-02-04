using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCarePharmacy_V3.Shared.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ProductImage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int Category { get; set; }
    }
}
