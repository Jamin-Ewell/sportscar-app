using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportscar_app.Domain.Entities;

namespace sportscar_app.Infrastructure.Data.Configurations;
public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
       // builder.Property(t => t.Title)
       //     .HasMaxLength(200)
       //     .IsRequired();
    }
}
