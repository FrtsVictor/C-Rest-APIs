using System.ComponentModel.DataAnnotations;

namespace Catalog_Net5.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; init; }

        [Required]
        [Range(1, 10000)]
        public decimal Price { get; init; }
    }
}