using System.ComponentModel.DataAnnotations;

namespace AndrewGardanier_Mission_6.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }

    }
}
