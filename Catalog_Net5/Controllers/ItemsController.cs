using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using Catalog_Net5.Repositories;
using Microsoft.AspNetCore.Mvc;
using Catalog_Net5.Entities;
using System;
using Catalog_Net5.Dtos;

namespace Catalog_Net5.Controllers
{
    [ApiController]
    [Route("v1/items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => item.AsDto());

            return items;

        }

        [HttpGet("{id}")]
        //With action Result i can return more than 1 type of element MVC in this case Not Found or item
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item is null)
            {
                return NotFound();
            }

            return item.AsDto();
        }
    }
}