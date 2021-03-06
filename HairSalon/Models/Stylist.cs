using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client> ();
    }

    public int StylistId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Speciality { get; set; }
    public int YearsOfExperience { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}