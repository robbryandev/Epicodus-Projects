using System.ComponentModel.DataAnnotations;

namespace BakeryAuth.Models 
{
  public class Treat {
    [Key]
    public int treat_id {get; set;}
    public string user_id {get; set;}
    public string name {get; set;}
    public string description {get; set;}
  }
}