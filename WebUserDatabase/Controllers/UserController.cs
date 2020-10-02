using DataModels;
using DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebUserDatabase.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            UserProvider userProvider = new UserProvider();
            return userProvider.SelectAll();
        }

        [HttpGet]
        public User GetById(int id)
        {
            UserProvider userProvider = new UserProvider();
            return userProvider.SelectById(id);
        }

        [HttpPost]
        public void AddUser(User user)
        {
            if (user == null)
                return;
            UserProvider userProvider = new UserProvider();
            userProvider.Insert(user);
        }

        [HttpDelete]
        public void DeleteUser(User user)
        {
            UserProvider userProvider = new UserProvider();
            userProvider.Delete(user);
        }
    }
}
