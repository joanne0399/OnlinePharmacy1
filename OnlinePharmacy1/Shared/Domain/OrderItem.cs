using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        [Required]
        public int OrderQty { get; set; }
        [Required]
        public int? OrderID { get; set; }
        public virtual Order Order { get; set; }
        [Required]
        public int? MedicationID { get; set; }
        public virtual Medication Medication { get; set; }
    }
}
