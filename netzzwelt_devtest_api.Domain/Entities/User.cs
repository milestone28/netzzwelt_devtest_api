using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Domain.Entities
{
    public class User
    {
        public string? username { get; set; }
        public string? password { get; set; }
        public string? displayName { get; set; }
        public string[]? roles { get; set; }
    }
}
