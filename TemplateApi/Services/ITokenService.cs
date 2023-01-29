using TemplateApi.Models;

namespace TemplateApi.Services
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}