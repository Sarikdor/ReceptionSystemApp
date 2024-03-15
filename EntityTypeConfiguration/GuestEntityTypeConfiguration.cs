using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.EntityTypeConfiguration;

public class GuestEntityTypeConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> entityTypeBuilder)
    {
        
    }
}