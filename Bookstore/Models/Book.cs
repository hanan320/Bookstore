using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Title can not be more than 50")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author name can not be more than 50")]
        public string Author { get; set; }

        [Range(1, 50, ErrorMessage = "Price must be between 1 and 50")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Genre can not be more than 50")]
        public string Genre { get; set; }
    }
}
