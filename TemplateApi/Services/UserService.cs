using TemplateApi.Commons.Exceptions;
using TemplateApi.Models;
using TemplateApi.Repositories;

namespace Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public User Post(RegUser regUser)
        {
            var user = new User
            {
                Name = regUser.Name,
                Login = regUser.Login,
                Password = regUser.Password,
                BirthDate = regUser.BirthDate

            };
            _repository.Create(user);
            return user;
        }

        public List<User> Get()
        {
            return _repository.Get();
        }

        public User Search(int id)
        {
            var searching = _repository.Search(id);
            if (searching == null)
                throw new NotFoundException("User not Found");
            return searching;
        }

        public User Put(UpdateUser updateUser, int id)
        {   
            var existentUser = Search(id);
            existentUser.Name = updateUser.Name;
            existentUser.BirthDate = updateUser.BirthDate;
            _repository.Put(existentUser);
            return existentUser;
        }

        public void Delete(int id)
        {   
            var searching = Search(id);
            _repository.Delete(searching);
        }
    }
}