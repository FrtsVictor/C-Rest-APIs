using System.Collections;
using System;
using System.Collections.Generic;
using Catalog_Net5.Entities;

namespace Catalog_Net5.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }

}

