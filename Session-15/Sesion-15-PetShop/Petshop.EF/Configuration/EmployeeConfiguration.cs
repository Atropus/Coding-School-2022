using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.EF.Configuration
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            //TODO na do pws tha doulepsei to GUID
            builder.ToTable("Employee");
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.ID).HasMaxLength(36);
            builder.Property(employee => employee.Name).HasMaxLength(60);
            builder.Property(employee => employee.Surname).HasMaxLength(60);
            builder.Property(employee => employee.EmpType).HasMaxLength(20);
            builder.Property(employee => employee.Salary).HasMaxLength(20);
            builder.HasIndex(employee => employee.Finished);

        }
    }
}
