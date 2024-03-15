using Microsoft.EntityFrameworkCore;
using ReceptionSystemApp.Model;

namespace ReceptionSystemApp.Data;

public class ReceptionSystemAppDbContext : DbContext
{
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Receptionist> Receptionists { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Room> Rooms { get; set; }
    
    public ReceptionSystemAppDbContext(DbContextOptions<ReceptionSystemAppDbContext> options) : base(options)
    {
        
    }
   
}
