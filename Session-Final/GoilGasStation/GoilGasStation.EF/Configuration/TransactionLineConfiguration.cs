using GoilGasStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.EF.Configuration
{
    internal class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            builder.HasKey(transLine => transLine.ID);
            builder.Property(transLine => transLine.Quantity).HasColumnType("decimal(10,2)");
            builder.Property(transLine => transLine.ItemPrice).HasColumnType("decimal(10,2)");
            builder.Property(transLine => transLine.NetValue).HasColumnType("decimal(10,2)");
            builder.Property(transLine => transLine.DiscountPercent).HasColumnType("decimal(2,2)");
            builder.Property(transLine => transLine.DiscountValue).HasColumnType("decimal(10,2)");
            builder.Property(transLine => transLine.TotalValue).HasColumnType("decimal(10,2)");
            builder.HasOne(transline => transline.Transaction).WithMany(transaction => transaction.TransactionLines).HasForeignKey(transline => transline.TransactionID);
            builder.HasOne(transline => transline.Item).WithMany(item => item.TransactionLines).HasForeignKey(transline => transline.ItemID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
