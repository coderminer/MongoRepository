using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Repository
{
    public class MongodbContext
    {
        private  IMongoDatabase database;
        private  IMongoClient client;
        private static MongodbContext context;
        private MongodbContext() { }

        public static MongodbContext Create(string connection)
        {
            if(context == null)
            {
                context = new MongodbContext();
                var url = MongoUrl.Create(connection);
                context.client = new MongoClient(url);
                context.database = context.client.GetDatabase(url.DatabaseName);
            }
            return context;
        }

        public IMongoCollection<T> GetCollection<T>()
        {
            return context.database.GetCollection<T>(typeof(T).Name);
        }
    }
}
