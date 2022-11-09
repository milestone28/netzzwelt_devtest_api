using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Contracts
{
    public record LoginRequest(
      string Username,
      string Password
      );
}
