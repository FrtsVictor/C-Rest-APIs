using System.ComponentModel.DataAnnotations;

namespace Net5_InMemoryDb.Models
{
    public class Product
    {

        [Key]

        public int Id { get; set; }


        [Required(ErrorMessage = "This filed is madatory")]
        [MaxLength(60, ErrorMessage = " This field should have more than 3 and less than 60 characters")]
        [MinLength(3, ErrorMessage = " This field should have more than 3 and less than 60 characters")]
        public string Name { get; set; }


        [MaxLength(1024, ErrorMessage = "This field should have less than 1024 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This filed is madatory")]
        [Range(1, int.MaxValue, ErrorMessage = "Price should be more higher than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This filed is madatory")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; } //to acess category information
    }
}