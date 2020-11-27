using System;

namespace Catalog_Net5.Dtos
{
    public class ItemDto
    {
        public Guid Id { get; init; }  //setting init for down allow modifications across the application
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}