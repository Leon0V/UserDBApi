using TemplateApi.Commons.Exceptions;
using TemplateApi.Models;
using TemplateApi.Repositories;
using TemplateApi.Services;

namespace Services
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        private ITokenService _tokenService;
        public UserService(IUserRepository repository, ITokenService tokenService)
        {
            _repository = repository;
            _tokenService = tokenService;
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

        public string Login(UserLogin userLogin)
        {
            var user = _repository.Search(userLogin.Login);
            if(user == null)
                throw new Exception("User not Authorized");
            if(userLogin.Password != user.Password)
                throw new Exception("User not Authorized");
            
            return _tokenService.GenerateToken(user);
            
        }
    }
}