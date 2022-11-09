using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netzzwelt_devtest_api.Contracts.Territories
{
    public class TerritoriesResponse
    {
        //public DataTerritories[]? data { get; set; }
        public List<DataTerritories> data = new List<DataTerritories>();
    }


    public class DataTerritories
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Parent { get; set; }
    }
}
