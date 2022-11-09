using BuberDinner.Api.Filters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using netzzwelt_devtest_api.Application.Authentication;
using netzzwelt_devtest_api.Contracts;

namespace netzzwelt_devtest_api.Api.Controllers
{
    [ApiController]
    [Route("Account")]
    [EnableCors("AllowAllOrigin")]
    [ErrorHandlingFilter]
    public class AccountController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("SignIn")]
        public IActionResult Login(LoginRequest req)
        {
  
            var authResult = _authenticationService.Login(
              req.Username,
              req.Password
              );

            var res = new AuthenticationResponse(
                authResult.User.username,
                authResult.User.displayName,
                authResult.User.roles
                );
            return Ok(res);
        }
    }
}
