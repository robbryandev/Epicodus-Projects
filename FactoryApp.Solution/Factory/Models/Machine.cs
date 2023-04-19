using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    [Key]
    public int machine_id { get; set; }
    public string name { get; set; }
  }
}