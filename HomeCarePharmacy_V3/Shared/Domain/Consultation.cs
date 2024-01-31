using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeCarePharmacy_V3.Shared.Domain
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string? ConsultationStatus { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
        public int StaffId { get; set; }
        public virtual Staff? Staff { get; set; }
    }
}
