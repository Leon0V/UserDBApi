//interface: this defines the contracts with its signatures; it defines its methods, the parameters and what not. the rest is set by its service class
//calling it interface with the actual code for its signatures
using TemplateApi.Models;

namespace TemplateApi.Repositories
{
    public interface IUserRepository
    {
        User Create(User user);
        List<User> Get();
        User? Search(int id);
        User Put(User user);
        void Delete(User user);

        User? Search(string login);
    }
}