using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class Consultation
    {
        public int ConsultationID { get; set; }
        public DateTime ConsultationDateTime { get; set; }
        public string Diagnosis { get; set; }
        public virtual Staff Staff { get; set; }
        public int StaffID { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustID { get; set; }
    }
}
