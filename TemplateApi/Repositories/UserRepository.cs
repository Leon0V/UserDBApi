using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace TemplateApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private UserContext _db;
        public UserRepository(UserContext db)
        {
            _db = db;
        }
        public User Create(User user)
        {
            _db.users.Add(user);
            _db.SaveChanges();
            return user;
        }
        public List<User> Get()
        {
            return _db.users.ToList();
        }

    }
}