using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Application.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Login(string username, string password);
    }
}
