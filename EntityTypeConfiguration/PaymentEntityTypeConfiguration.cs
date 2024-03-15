using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.EntityTypeConfiguration;

public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> entityTypeBuilder)
    {
        
    }
}