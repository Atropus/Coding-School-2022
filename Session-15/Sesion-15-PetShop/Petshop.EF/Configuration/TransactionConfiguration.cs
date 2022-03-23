using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.EF.Configuration
{
    internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            //TODO na do pws tha doulepsei to GUID
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);
            builder.Property(transaction => transaction.ID).HasMaxLength(36);
            builder.Property(transaction => transaction.Date).HasMaxLength(60);
            builder.Property(transaction => transaction.CustomerID).HasMaxLength(36);
            builder.Property(transaction => transaction.EmployeeID).HasMaxLength(36);
            builder.Property(transaction => transaction.PetID).HasMaxLength(36);
            builder.Property(transaction => transaction.PetPrice).HasMaxLength(100);
            builder.Property(transaction => transaction.PetFoodID).HasMaxLength(36);
            builder.Property(transaction => transaction.PetFoodQty).HasMaxLength(20);
            builder.Property(transaction => transaction.PetFoodPrice).HasMaxLength(100);
            builder.Property(transaction => transaction.TotalPrice).HasMaxLength(100);

        }
    }
}