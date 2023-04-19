using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class EngineerMachine
  {
    [Key]
    public int engineer_machine_id { get; set; }
    public int engineer_id { get; set; }
    public Engineer Engineer { get; set; }
    public int machine_id { get; set; }
    public Machine Machine { get; set; }
  }
}