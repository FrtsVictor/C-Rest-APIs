using System.Collections;
using System;
using System.Collections.Generic;
using Catalog_Net5.Entities;
using System.Threading.Tasks;

namespace Catalog_Net5.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);

        Task UpdateItemAsync(Item item);

        Task DeleteItemAsync(Guid id);
    }

}

