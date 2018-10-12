using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Models
{
    public class UserModel : IEntity
    {
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public int sex { get; set; }
        public string avatar { get; set; }
    }
}
