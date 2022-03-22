using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Session_14.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14.EF.Configuration
{
    internal class Configuration : IEntityTypeConfiguration<Prop>
    {
        public void Configure(EntityTypeBuilder<Prop> builder)
        {
            builder.ToTable("Prop");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Id).ValueGeneratedOnAdd();
        }
    }
}
