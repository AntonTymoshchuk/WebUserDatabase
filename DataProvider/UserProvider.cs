using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider
{
    public class UserProvider
    {
        private DatabaseContext databaseContext;

        public UserProvider()
        {
            databaseContext = new DatabaseContext();
        }

        public IEnumerable<User> SelectAll()
        {
            //DatabaseContext databaseContext = new DatabaseContext();
            return databaseContext.Users.Select(s => s).ToList();
        }

        public User SelectById(int id)
        {
            //DatabaseContext databaseContext = new DatabaseContext();
            //foreach (User user in databaseContext.Users)
            //{
            //    if (user.Id == id)
            //        return user;
            //}
            //return null;
            return databaseContext.Users.FirstOrDefault(f => f.Id == id);
        }

        public void Update(User user)
        {
            var updatedUser = databaseContext.Users.FirstOrDefault(f => f.Id == user.Id);
            updatedUser.FirstName = user.FirstName;
            updatedUser.LastName = user.LastName;
            updatedUser.Age = user.Age;
            updatedUser.Email = user.Email;
            updatedUser.Phone = user.Phone;
        }

        public void Insert(User user)
        {
            //DatabaseContext databaseContext = new DatabaseContext();
            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();
        }
        
        public void Delete(User user)
        {
            //DatabaseContext databaseContext = new DatabaseContext();
            databaseContext.Users.Attach(user);
            databaseContext.Users.Remove(user);
        }
    }
}
