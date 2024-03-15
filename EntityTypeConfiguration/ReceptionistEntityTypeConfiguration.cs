using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.EntityTypeConfiguration;

public class ReceptionistEntityTypeConfiguration : IEntityTypeConfiguration<Receptionist>
{
    public void Configure(EntityTypeBuilder<Receptionist> entityTypeBuilder)
    {
        
    }
}