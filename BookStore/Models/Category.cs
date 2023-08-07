using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Category
    {
        public int Category21Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int DisplayOrder { get; set;}
    }
}
