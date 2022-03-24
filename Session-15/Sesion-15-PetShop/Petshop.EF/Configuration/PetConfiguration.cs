using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.EF.Configuration
{
    internal class PetConfiguration : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            //TODO na do pws tha doulepsei to GUID
            builder.ToTable("Pet");
            builder.HasKey(pet => pet.ID);
            builder.Property(Pet => Pet.ID).HasMaxLength(36);
            builder.Property(pet => pet.Price).HasMaxLength(20);
            builder.Property(pet => pet.Cost).HasMaxLength(20);
            //builder.Property(pet => pet.FoodType);
            builder.Property(pet => pet.HealthStatus).HasMaxLength(60);
            builder.Property(pet => pet.AnimalType).HasMaxLength(60);
            builder.Property(pet => pet.Breed).HasMaxLength(60);
            

        }
    }
}