using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Contracts.Territories
{
    public class ResponseDataModel<T> 
    {
        public T data { get; set; }
    }
}
