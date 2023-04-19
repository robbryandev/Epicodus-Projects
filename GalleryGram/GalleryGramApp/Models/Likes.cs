using MySqlConnector;
using System.ComponentModel.DataAnnotations;

namespace GalleryGram.Models
{
    public class Likes
    {
        [Key]
        public int like_id {get; set;}
        public int picture_id {get; set;}
        public string user_id {get; set;}
    }
}