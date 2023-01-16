using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderQty { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int MedicationID { get; set; }
        public virtual Medication Medication { get; set; }
    }
}
