using System.ComponentModel.DataAnnotations;

namespace BakeryAuth.Models 
{
  public class TreatFlavor {
    [Key]
    public int treatflavor_id {get; set;}
    public int treat_id {get; set;}
    public int flavor_id {get; set;}
  }
}