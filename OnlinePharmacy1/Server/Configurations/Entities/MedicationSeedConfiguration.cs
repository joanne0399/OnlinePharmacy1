using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy1.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Server.Configurations.Entities
{
    public class MedicationSeedConfiguration : IEntityTypeConfiguration<Medication>
    {
        public void Configure(EntityTypeBuilder<Medication> builder)
        {
            builder.HasData(
                new Medication
                {
                    MedicationID = 1,
                    MedicationName = "Panadol",
                    Description = "Treat mild to moderate pain (from headaches, menstrual periods, toothaches, backaches, osteoarthritis, or cold/flu aches and pains) and to reduce fever",
                    Ingredients = "500 mg of paracetamol",
                    RecommendedDosage = "Take 1-2 tablets every 4-6 hours as required",
                    Availability = "In stock"
                },
                new Medication
                {
                    MedicationID = 2,
                    MedicationName = "Woods Peppermint Adult Cough Syrup",
                    Description = "Relieves coughing, soothes sore throat, loosens phlegm and expels mucus",
                    Ingredients = "Guaiphenesin, Benzoic Acid",
                    RecommendedDosage = "Adults and children (12 years and over): 2 teaspoons (10ml), to be taken every 4 hours as prescribed by a healthcare professional",
                    Availability = "In stock"
                }
            );
        }
    }
}
