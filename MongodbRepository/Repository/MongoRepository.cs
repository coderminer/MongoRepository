using MongoDB.Bson;
using MongoDB.Driver;
using MongodbRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Repository
{
    public class MongoRepository<T> : IMongoRepository<T> where T : IEntity
    {
        private MongodbContext _context;
        public MongoRepository(string connection)
        {
            _context = MongodbContext.Create(connection);
        }
        public bool Delete(string id)
        {
            var filter = Builders<T>.Filter.Eq(m => m.id, id);
            var result = _context.GetCollection<T>().DeleteOne(filter);
            return result.DeletedCount > 0;
        }

        public IEnumerable<T> GetAll()
        {
            var filter = Builders<T>.Filter.Empty;
            return _context.GetCollection<T>().Find(filter).ToList();
        }

        public T GetOne(string id)
        {
            var filter = Builders<T>.Filter.Eq(m => m.id, id);
            return _context.GetCollection<T>().Find(filter).FirstOrDefault();
        }

        public void Insert(T item)
        {
            item.id = ObjectId.GenerateNewId(DateTime.Now).ToString();
            _context.GetCollection<T>().InsertOne(item);
        }

        public void InsertMany(IEnumerable<T> items)
        {
            _context.GetCollection<T>().InsertMany(items);
        }

        public bool Update(T item)
        {
            var filter = Builders<T>.Filter.Eq(m => m.id, item.id);
            var result = _context.GetCollection<T>().ReplaceOne(filter, item);
            return result.ModifiedCount > 0;
        }

        
    }
}
