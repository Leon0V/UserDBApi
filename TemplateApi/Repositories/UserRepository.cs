//user services contains the contracts for the User class. this is later called in the controller. Basically, the service connects to the database
//as the first step, so later on the controller works with said contracts here present
using TemplateApi.Models;

namespace TemplateApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        //injection for the repository
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

        public User? Search(int id)
        {
            return _db.users.FirstOrDefault(x => x.Id == id);
        }

        public User Put(User user)
        {
            _db.users.Update(user);
            _db.SaveChanges();
            return user;
        }
        public void Delete(User user)
        {
            _db.users.Remove(user);
            _db.SaveChanges();
        }

    }
}