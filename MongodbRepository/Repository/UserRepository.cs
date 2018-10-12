using MongodbRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Repository
{
    public class UserRepository : MongoRepository<UserModel>,IUserRepository
    {
        public UserRepository(string connection) : base(connection)
        {
        }
    }
}
