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
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(employee => employee.ID);
            builder.Property(employee => employee.Name).HasMaxLength(60);
            builder.Property(employee => employee.Surname).HasMaxLength(60);
            builder.Property(employee => employee.SalaryPerMonth).HasColumnType("decimal(10,2)");

        }
    }
}
