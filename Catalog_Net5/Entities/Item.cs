using System;

namespace Catalog_Net5.Entities
{
    public record Item
    {
        public Guid Id { get; init; }  //setting init for down allow modifications across the application
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; set; }

    }
}





//can do
// Item item = new()
// {
// Id = Guid.NewGuid();
// }

//can't do
// Item.Id = Guid.NewGuid()