using System.ComponentModel.DataAnnotations;

namespace Net5_InMemoryDb.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }


        [Required(ErrorMessage = "This filed is madatory")]
        [MaxLength(60, ErrorMessage = " This field should have more than 3 and less than 60 characters")]
        [MinLength(3, ErrorMessage = " This field should have more than 3 and less than 60 characters")]
        public string Name { get; set; }

    }
}