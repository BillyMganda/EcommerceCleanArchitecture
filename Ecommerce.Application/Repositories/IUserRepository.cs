using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
    }
}
