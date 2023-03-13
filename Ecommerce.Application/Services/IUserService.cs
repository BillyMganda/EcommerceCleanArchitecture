using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Services
{
    public interface IUserService
    {
        List<User> GetAllUsers();
    }
}
