using DAW.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAW.Domain.EF.ModelConfigurations
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id);
            builder.HasOne(c => c.SuperiorId);
        }
    }
}