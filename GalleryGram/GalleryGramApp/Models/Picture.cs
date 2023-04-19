using MySqlConnector;
using System.ComponentModel.DataAnnotations;

namespace GalleryGram.Models 
{
    public class Picture
    {
        [Key]
        public int picture_id {get; set;}
        public string user_id {get; set;}
        public string fileName {get; set;}
    }
}