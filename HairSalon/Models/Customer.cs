namespace HairSalon.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Rating{ get; set; }
    public int Price{ get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}