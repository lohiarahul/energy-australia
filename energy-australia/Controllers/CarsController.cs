using energy_australia.Exceptions;
using energy_australia.Models;
using energy_australia.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace energy_australia.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/carcontroller")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        // GET: api/Car
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            try
            {
                return _carService.GetCars();
            }
            catch(Exception e)
            {
                throw new MyException(e.Message, e);
            }
        }

       
    }
}
