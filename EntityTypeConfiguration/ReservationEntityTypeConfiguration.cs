using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.EntityTypeConfiguration;

public class ReservationEntityTypeConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> entityTypeBuilder)
    {
        
    }
}