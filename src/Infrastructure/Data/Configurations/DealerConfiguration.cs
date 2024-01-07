using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using sportscar_app.Domain.Entities;

namespace sportscar_app.Infrastructure.Data.Configurations;
public class DealerConfiguration : IEntityTypeConfiguration<Dealer>
{
    public void Configure(EntityTypeBuilder<Dealer> builder)
    {
        throw new NotSupportedException();
    }
}
