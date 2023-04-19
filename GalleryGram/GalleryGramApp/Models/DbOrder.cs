using System.ComponentModel.DataAnnotations;

namespace GalleryGram.Models
{
    public class DbOrder
    {
        [Key]
        public int order_id {get; set;}
        public string user_id { get; set; }
        public string confirmation_id {get; set;}
        public string status {get; set;}
        public string cost {get; set;}
    }
}