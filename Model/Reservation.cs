namespace ReceptionSystemApp.Model;

public class Reservation
{
    public int ReservationId { get; set; }
    public Guest Guest { get; set; }
    public Room Room { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    
}