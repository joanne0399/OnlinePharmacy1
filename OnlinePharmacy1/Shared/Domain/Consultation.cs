using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class Consultation
    {
        public int ConsultationID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime ConsultationDateTime { get; set; }
        [Required]
        public string Diagnosis { get; set; }
        [Required]
        public int? StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        [Required]
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
