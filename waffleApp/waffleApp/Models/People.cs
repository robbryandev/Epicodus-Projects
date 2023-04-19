using System.ComponentModel.DataAnnotations;

namespace waffle.Models {
    public class People {
        [Key]
        public int person_id {get; set;}
        public string name {get; set;}
        public string birthday {get; set;}
    }
}