using energy_australia.Models;
using energy_australia.Services.Contracts;
using System.Collections.Generic;

namespace energy_australia.Services.Concretes
{
    public class CarService: ICarService
    {

        // Create dummy cars
        public IEnumerable<Car> GetCars()
        {
            return new List<Car> {
            new Car{ Make="HENNESSEY", Model="VENOM F5"},
            new Car{ Make="KOENIGSEGG", Model="AGERA RS"},
            new Car{ Make="HENNESSEY", Model="VENOM GT"},
            new Car{ Make="BUGATTI", Model="CHIRON"},
            new Car{ Make="BUGATTI", Model="VEYRON SUPER SPORT"},
            new Car{ Make="SCC", Model="ULTIMATE AERO"},
            new Car{ Make="TESLA", Model="ROADSTER"},
            new Car{ Make="SALEEN", Model="S7 TWIN TURBO"},
            new Car{ Make="KOENIGSEGG", Model="CCR"},
            new Car{ Make="MCLAREN", Model="F1"},
        };
        }
    }
}
