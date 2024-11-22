using System.ComponentModel.DataAnnotations;

namespace Pronia_P_1_1.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, StringLength(20, ErrorMessage = "Uzunluq max 20 olur")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string SubTitle { get; set; }
        public string ImgUrl { get; set; }
    }
}
