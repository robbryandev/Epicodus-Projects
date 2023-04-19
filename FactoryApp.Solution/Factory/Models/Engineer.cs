using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    [Key]
    public int engineer_id { get; set; }
    public string name { get; set; }
  }
}