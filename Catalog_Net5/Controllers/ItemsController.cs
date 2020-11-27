using System.Collections.Generic;
using Catalog_Net5.Repositories;
using Microsoft.AspNetCore.Mvc;
using Catalog_Net5.Entities;
using System;

namespace Catalog_Net5.Controllers
{
    [ApiController]
    [Route("v1/items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemoryRepository repository;

        public ItemsController()
        {
            repository = new InMemoryRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;

        }

        [HttpGet("{id}")]
        //With action Result i can return more than 1 type of element MVC in this case Not Found or item
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
            {
                return NotFound();
            }

            return item;
        }
    }
}