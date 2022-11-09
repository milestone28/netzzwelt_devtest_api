using BuberDinner.Application.Common.Interfaces.Persistence;
using netzzwelt_devtest_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Application.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserRepository _userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public AuthenticationResult Login(string username, string password)
        {
            //1. Validate the user doesn't exist

            if (_userRepository.GetUserByUsername(username) is not User user)
            {
              
                throw new Exception("Invalid username or password.");
                
            }

            //2. Validate the password is correct
            if (user.password != password)
            {
                throw new Exception("Invalid username or password.");
            }


            return new AuthenticationResult(
               user);
        }
    }
    
}
