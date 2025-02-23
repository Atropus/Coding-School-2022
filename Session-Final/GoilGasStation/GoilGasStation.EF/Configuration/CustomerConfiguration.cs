﻿using GoilGasStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.EF.Configuration
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.ID);
            builder.Property(customer => customer.Name).HasMaxLength(60);
            builder.Property(customer => customer.Surname).HasMaxLength(60);
            builder.Property(customer => customer.CardNumber).HasMaxLength(20);

        }
    }
}
