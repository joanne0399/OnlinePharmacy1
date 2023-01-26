using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Shared.Domain
{
    public class Medication
    {
        public int MedicationID { get; set; }
        [Required]
        public string MedicationName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Ingredients { get; set; }
        [Required]
        public string RecommendedDosage { get; set; }
        [Required]
        public string Availability { get; set; }
    }
}
