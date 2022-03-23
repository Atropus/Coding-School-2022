using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.EF.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            //TODO na do pws tha doulepsei to GUID
            builder.ToTable("Customer");
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.ID).HasMaxLength(36);
            builder.Property(customer => customer.Name).HasMaxLength(100);
            builder.Property(customer => customer.Surname).HasMaxLength(100);
            builder.Property(customer => customer.Tin).HasMaxLength(20);
            builder.Property(customer => customer.PhoneNumber).HasMaxLength(20);
            builder.HasIndex(customer => customer.Finished);
            
        }
    }
}
