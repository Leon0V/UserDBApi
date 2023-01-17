using LoginApi.Models.Users;
using Models;

namespace Services
{
    public interface IUserService
    {
        User Post(RegUser regUser);
    }
}