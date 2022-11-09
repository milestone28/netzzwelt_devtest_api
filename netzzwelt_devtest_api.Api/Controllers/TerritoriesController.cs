using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using netzzwelt_devtest_api.Contracts.Territories;
using netzzwelt_devtest_api.Domain.Entities;
using System.Collections;
using System.Web.Http.Description;

namespace netzzwelt_devtest_api.Api.Controllers
{
    [ApiController]
    [Route("Territories")]
    [EnableCors("AllowOrigin")]

    public class TerritoriesController : Controller
    {

        //private List<Territories> _territories = new List<Territories>()
        //{
        //    new Territories(){     Id = "1", Name = "Metro Manila", Parent = "teest" },
        //      new Territories(){     Id = "2", Name = "Metro Manila2", Parent = "teest"  }
        //};


        [HttpGet("All")]

        [ResponseType(typeof(ResponseDataModel<List<DataTerritories>>))]
        public IActionResult GetTerritories()
        {

            List<DataTerritories> _territories = new List<DataTerritories>();
            _territories.Add(new DataTerritories { Id = "1", Name = "Metro Manila", Parent = null });
            _territories.Add(new DataTerritories { Id = "101", Name = "Manila", Parent = "1" });
            _territories.Add(new DataTerritories { Id = "10101", Name = "Malate", Parent = "101" });
            _territories.Add(new DataTerritories { Id = "10102", Name = "Ermita", Parent = "101" });
            _territories.Add(new DataTerritories { Id = "10103", Name = "Binondo", Parent = "101" });
            _territories.Add(new DataTerritories { Id = "102", Name = "Makati", Parent = "1" });
            _territories.Add(new DataTerritories { Id = "10201", Name = "Poblacion", Parent = "102" });
            _territories.Add(new DataTerritories { Id = "10202", Name = "Bel-Air", Parent = "102" });
            _territories.Add(new DataTerritories { Id = "10203", Name = "San Lorenzo", Parent = "102" });
            _territories.Add(new DataTerritories { Id = "10204", Name = "Urdaneta", Parent = "102" });
            _territories.Add(new DataTerritories { Id = "103", Name = "Marikina", Parent = "1" });
            _territories.Add(new DataTerritories { Id = "10301", Name = "Sto Nino", Parent = "103" });
            _territories.Add(new DataTerritories { Id = "10302", Name = "Malanday", Parent = "103" });
            _territories.Add(new DataTerritories { Id = "10303", Name = "Concepcion I", Parent = "103" });
            _territories.Add(new DataTerritories { Id = "2", Name = "CALABARZON", Parent = null });
            _territories.Add(new DataTerritories { Id = "201", Name = "Laguna", Parent = "2" });
            _territories.Add(new DataTerritories { Id = "20101", Name = "Calamba", Parent = "201" });
            _territories.Add(new DataTerritories { Id = "20102", Name = "Sta. Rosa", Parent = "201" });
            _territories.Add(new DataTerritories { Id = "202", Name = "Cavite", Parent = "2" });
            _territories.Add(new DataTerritories { Id = "20201", Name = "Kawit", Parent = "202" });
            _territories.Add(new DataTerritories { Id = "203", Name = "Batangas", Parent = "2" });
            _territories.Add(new DataTerritories { Id = "20301", Name = "Lipa", Parent = "203" });
            _territories.Add(new DataTerritories { Id = "20302", Name = "Tanauan", Parent = "203" });
            _territories.Add(new DataTerritories { Id = "3", Name = "Central Luzon", Parent = null });
            _territories.Add(new DataTerritories { Id = "301", Name = "Bulacan", Parent = "3" });
            _territories.Add(new DataTerritories { Id = "302", Name = "Nueva Ecija", Parent = "3" });
            _territories.Add(new DataTerritories { Id = "303", Name = "Tarlac", Parent = "3" });
            _territories.Add(new DataTerritories { Id = "304", Name = "Pampanga", Parent = "3" });

            TerritoriesResponse _territoriesList = new TerritoriesResponse();
            _territoriesList.data = new List<DataTerritories>();
            _territoriesList.data = _territories;


            return Ok( new ResponseDataModel<List<DataTerritories>> {  data = _territoriesList.data });
        }

    }
}
