using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongodbRepository.Models;
using MongodbRepository.Repository;

namespace MongodbRepository.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserModel> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public void Register(UserModel model)
        {
            _userRepository.Insert(model);
        }
    }
}
