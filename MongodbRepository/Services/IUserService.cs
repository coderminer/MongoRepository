using MongodbRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbRepository.Services
{
    public interface IUserService
    {
        void Register(UserModel model);
        IEnumerable<UserModel> GetAllUsers();
    }
}
