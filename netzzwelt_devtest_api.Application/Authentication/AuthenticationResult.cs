using netzzwelt_devtest_api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Application.Authentication
{
    public record AuthenticationResult(
     User User
     );
}
