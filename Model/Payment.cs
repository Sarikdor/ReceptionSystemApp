namespace ReceptionSystemApp.Model;

public class Payment
{
   public int PaymentId { get; set; }
   public Reservation Reservation { get; set; }
   public float Amount { get; set; }
   public DateTime PaymnetDate { get; set; }
}