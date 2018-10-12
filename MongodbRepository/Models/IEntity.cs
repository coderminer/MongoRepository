using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Models
{
    public class IEntity
    {
        [BsonId]
        public string id { get; set; }
        public long date { get; set; }
    }
}
