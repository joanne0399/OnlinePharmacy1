using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePharmacy1.Shared.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePharmacy1.Server.Configurations.Entities
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    CustomerID = 1,
                    CustomerName = "Jennie",
                    CustomerNRIC = "S9523810J",
                    CustomerEmail = "Jennieninini@gmail.com",
                    CustomerAddress = "Bedok North Rd Blk 428 #09-387",
                    CustomerContactNo = "90818473",
                    CustomerDOB = "15 January 1995"
                },
                new Customer
                {
                    CustomerID = 2,
                    CustomerName = "Jay",
                    CustomerNRIC = "S9901807D",
                    CustomerEmail = "Jayjj@gmail.com",
                    CustomerAddress = "Sin Ming Ave Blk 76 #14-902",
                    CustomerContactNo = "98017489",
                    CustomerDOB = "23 November 1999"
                }
            );
        }
    }
}
