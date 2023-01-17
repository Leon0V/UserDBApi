using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace TemplateApi.Repositories
{
    public interface IUserRepository
    {
        User Create(User user);
        List<User> Get();
    }
}