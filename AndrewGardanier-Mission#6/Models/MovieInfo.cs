using System.ComponentModel.DataAnnotations;

namespace AndrewGardanier_Mission_6.Models
{
    public class MovieInfo
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string SubCategory { get; set; }

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public int MovieYear { get; set; }
        
        [Required]
        public string Director { get; set; }
        [Required]
        public string CoDirector { get; set; }

        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
