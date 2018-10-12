using MongodbRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Repository
{
    public interface IMongoRepository<T> where T : IEntity
    {
        void Insert(T item);
        void InsertMany(IEnumerable<T> items);
        IEnumerable<T> GetAll();
        T GetOne(string id);
        bool Update(T item);

        bool Delete(string id);
    }
}
