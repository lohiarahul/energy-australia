using energy_australia.Exceptions;
using energy_australia.Models;
using energy_australia.Services.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace energy_australia.Services.Concretes
{
    public class CarShowService : ICarShowService
    {
        private ICarService _carService;

        public CarShowService(ICarService carService)
        {
            _carService = carService;
        }

        public IEnumerable<CarShow> GetCarShows()
        {
            var cars = _carService.GetCars();

            // Create dummy mapping
            var carShows = new List<CarShow>();
            string[] carShowNames = GetCarShowNames();
            int i = 0;
            foreach (string carShowName in carShowNames)
            {
                CarShow carShow = new CarShow { Name = carShowName };
                carShow.Cars = new List<Car>();
                carShow.Cars.AddRange(cars.Skip(i).Take(2));
                i += 2;
                carShows.Add(carShow); 
            }
            return carShows;

        }

        private string[] GetCarShowNames()
        {
            string[] carShowNames = new string[]
            {
                "IAA Cars Frankfurt",
                "Paris Global Motor Show",
                "NAIAS North American International Motor Show",
                "Geneva Motor Show",
                "Auto Shanghai"
            };
            return carShowNames;
        }
    }
}
