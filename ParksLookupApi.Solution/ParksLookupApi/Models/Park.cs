using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models {
    public class Park {
        [Key]
        public int? park_id {get; set;}
        public int state_id {get; set;}
        public string name {get; set;}
    }
}