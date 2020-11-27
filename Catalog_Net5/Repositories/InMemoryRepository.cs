using System.Collections;
using System;
using System.Collections.Generic;
using Catalog_Net5.Entities;
using System.Linq;

namespace Catalog_Net5.Repositories
{
    public class InMemoryRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Iron Shield", Price = 17, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 3, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 12, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Sword", Price = 15, CreatedDate = DateTimeOffset.Now }
        };
        public IEnumerable<Item> GetItems() //creating a iterable list
        {
            return items;
        }

        public Item GetItem(Guid id) //retrive item based on iterable list
        {
            return items.Where(items => items.Id == id).SingleOrDefault();
        }

    }
}

