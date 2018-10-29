using energy_australia.Models;
using energy_australia.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace energy_australia.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cars")]
    [ApiController]
    public class CarShowsController : ControllerBase
    {
        private ICarShowService _carShowService;

        public CarShowsController(ICarShowService carShowService)
        {
            _carShowService = carShowService;
        }
        // GET: api/CarShow
        [HttpGet]
        public IEnumerable<CarShow> Get()
        {

            return _carShowService.GetCarShows();
        }
    }
}
