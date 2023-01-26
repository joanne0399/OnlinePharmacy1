using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy1.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace OnlinePharmacy1.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                StaffID = 1,
                StaffName = "Lisa",
                StaffContactNo = "89103135",
                StaffAddress = "Bedok North Rd Blk 56 #11-902",
                StaffNRIC = "S9701923J",
                StaffEmail = "Lalisa@gmail.com"
            },
            new Staff
            {
                StaffID = 2,
                StaffName = "Paul",
                StaffContactNo = "93018402",
                StaffAddress = "Toh Guan Rd Blk 236 #02-651",
                StaffNRIC = "S86019395D",
                StaffEmail = "Paul@gmail.com",
            }, 
            new Staff
            {
                 StaffID = 3,
                 StaffName = "Pauline",
                 StaffContactNo = "93018403",
                 StaffAddress = "Toh Guan Rd Blk 237 #02-651",
                 StaffNRIC = "S87019395D",
                 StaffEmail = "Pauline@gmail.com",
            }
            );
        }
    }
}