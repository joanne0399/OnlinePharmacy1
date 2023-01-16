using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class Medication
    {
        public int MedicationID { get; set; }
        public string MedicationName { get; set; }
        public string Description { get; set; }
        public string Ingredient { get; set; }
        public string RecommendedDosage { get; set; }
        public Boolean Availability { get; set; }
    }
}
