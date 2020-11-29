using System.Collections;
using System;
using System.Collections.Generic;
using Catalog_Net5.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog_Net5.Repositories
{
    public class InMemoryRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Iron Shield", Price = 17, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 3, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 12, CreatedDate = DateTimeOffset.Now },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Sword", Price = 15, CreatedDate = DateTimeOffset.Now }
        };
        public async Task<IEnumerable<Item>> GetItemsAsync() //creating a iterable list
        {
            return await Task.FromResult(items);
        }

        public async Task<Item> GetItemAsync(Guid id) //retrive item based on iterable list
        {
            var item = items.Where(items => items.Id == id).SingleOrDefault();
            return await Task.FromResult(item);
        }

        public async Task CreateItemAsync(Item item)
        {
            items.Add(item);
            await Task.CompletedTask;
        }

        public async Task UpdateItemAsync(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            items[index] = item;
            await Task.CompletedTask;
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            items.RemoveAt(index);
            await Task.CompletedTask;

        }
    }
}

