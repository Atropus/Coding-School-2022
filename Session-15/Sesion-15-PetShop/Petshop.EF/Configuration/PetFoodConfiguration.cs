using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.EF.Configuration
{
    internal class PetFoodConfiguration : IEntityTypeConfiguration<PetFood>
    {
        public void Configure(EntityTypeBuilder<PetFood> builder)
        {
            //TODO na do pws tha doulepsei to GUID
            builder.ToTable("PetFood");
            builder.HasKey(petfood => petfood.ID);
            builder.Property(petfood => petfood.ID).HasMaxLength(36);
            builder.Property(petfood => petfood.Price).HasMaxLength(20);
            builder.Property(petfood => petfood.Cost).HasMaxLength(20);
            builder.Property(petfood => petfood.Type).HasMaxLength(60);
            builder.Property(petfood => petfood.Brand).HasMaxLength(60);
            builder.HasIndex(petfood => petfood.Finished);

        }
    }
}