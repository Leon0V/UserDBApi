using TemplateApi.Models;
namespace Services
{
    public interface IUserService
    {
        User Post(RegUser regUser);
        List<User> Get();
        User Search(int id);
        User Put(UpdateUser updateUser, int id);
        void Delete(int id);
    }
}