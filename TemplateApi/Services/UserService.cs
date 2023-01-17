using LoginApi.Models.Users;
using Models;
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
                Password = regUser.Password

            };
            _repository.Create(user);
            return user;
        }
    }
}