using netzzwelt_devtest_api.Domain.Entities;

namespace BuberDinner.Application.Common.Interfaces.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByUsername(string username);
    }
}
