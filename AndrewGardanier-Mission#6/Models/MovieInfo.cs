using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndrewGardanier_Mission_6.Models
{
    public class MovieInfo
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        [ForeignKey("CategoryId")] // make it so that you have to accept categoryID
        public int CategoryId { get; set; }
        
        //change back to Category if this doesn't work
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you need to enter a Movie Title")]
        public string MovieTitle { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "You must choose a year after 1888")]
        public int MovieYear { get; set; } = 0;

        [Required(ErrorMessage = "Sorry, you need to enter the Name of the director")]
        public string Director { get; set; }

        public string? CoDirector { get; set; }

        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }

        public string? LentTo { get; set; }

        [Required]
        public bool CopiedToPlex { get; set; }

        [MaxLength(25)]
        public string? Notes { get; set; }
    }
}
