using System.ComponentModel.DataAnnotations;

namespace BakeryAuth.ViewModels
{
  public class AddFlavorViewModel
  {
    [Required]
    [Display(Name = "Name")]
    public string name { get; set; }
  }
}