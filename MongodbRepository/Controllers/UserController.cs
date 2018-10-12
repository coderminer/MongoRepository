using MongodbRepository.Models;
using MongodbRepository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MongodbRepository.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        public IHttpActionResult Post([FromBody] UserModel model)
        {
            _userService.Register(model);
            return Ok(model);
        }


        public IHttpActionResult Get()
        {
            return Ok(_userService.GetAllUsers());
        }
    }
}
