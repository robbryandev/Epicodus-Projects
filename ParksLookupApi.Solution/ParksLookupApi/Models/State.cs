using System.ComponentModel.DataAnnotations;

namespace ParksLookupApi.Models {
    public class State {
        [Key]
        public int? state_id {get; set;}
        public string name {get; set;}
        public int park_count {get; set;}
    }
}