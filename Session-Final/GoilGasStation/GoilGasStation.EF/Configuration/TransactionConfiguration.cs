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
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.TotalValue).HasColumnType("decimal(10,2)");
            builder.HasOne(transaction => transaction.Employee).WithMany(employee => employee.Transactions).HasForeignKey(transaction => transaction.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(transaction => transaction.Customer).WithMany(customer => customer.Transactions).HasForeignKey(transaction => transaction.CustomerID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
