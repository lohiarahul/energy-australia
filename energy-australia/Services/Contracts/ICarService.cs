using energy_australia.Models;
using System.Collections.Generic;

namespace energy_australia.Services.Contracts
{
    public interface ICarService
    {
        IEnumerable<Car> GetCars();
    }
}
