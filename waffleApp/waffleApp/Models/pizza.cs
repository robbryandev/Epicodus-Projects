using System.ComponentModel.DataAnnotations;

namespace waffle.Models {
    public class Pizza {
        [Key]
        public int pizza_id {get; set;}
        public string type {get; set;}
    }
}