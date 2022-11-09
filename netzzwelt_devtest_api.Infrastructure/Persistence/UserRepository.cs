using BuberDinner.Application.Common.Interfaces.Persistence;
using netzzwelt_devtest_api.Domain.Entities;

namespace BuberDinner.Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new ();
        
        public User? GetUserByUsername(string _username)
        {
            var userExist = _users.Find(x => x.username == _username);
            if (userExist == null && _users.Count == 0)
            {
                string[] _roles = new string[] { "basic-user" };
                _users.Add(new User() { username = "foo", password = "bar", displayName = "Foo Bar Foo", roles = _roles });
            }

            return _users.SingleOrDefault(x => x.username == _username);
        }
    
    }
}
