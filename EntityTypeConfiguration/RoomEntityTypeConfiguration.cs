using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.EntityTypeConfiguration;

public class RoomEntityTypeConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> entityTypeBuilder)
    {
        
    }
}