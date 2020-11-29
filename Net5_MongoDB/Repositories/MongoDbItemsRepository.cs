using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Catalog_Net5.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Catalog_Net5.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "catalog";
        private string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;
        private readonly FilterDefinitionBuilder<Item> filterBuilder = Builders<Item>.Filter;

        public MongoDbItemsRepository(IMongoClient mongoCLient)
        {
            IMongoDatabase database = mongoCLient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }
        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await itemsCollection.Find(new BsonDocument()).ToListAsync();
        }
        public async Task<Item> GetItemAsync(Guid id)
        {
            var filter = filterBuilder.Eq(item => item.Id, id);
            return await itemsCollection.Find(filter).SingleOrDefaultAsync();
        }


        public async Task UpdateItemAsync(Item item)
        {
            var filter = filterBuilder.Eq(existingItem => existingItem.Id, item.Id);
            await itemsCollection.ReplaceOneAsync(filter, item);
        }

        public async Task CreateItemAsync(Item item)
        {
            await itemsCollection.InsertOneAsync(item);
        }

        public async Task DeleteItemAsync(Guid id)
        {
            var filter = filterBuilder.Eq(existingItem => existingItem.Id, id);
            await itemsCollection.DeleteOneAsync(filter);
        }

    }
}