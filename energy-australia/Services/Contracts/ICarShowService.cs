using energy_australia.Models;
using System.Collections.Generic;

namespace energy_australia.Services.Contracts
{
    public interface ICarShowService
    {
        IEnumerable<CarShow> GetCarShows();
    }
}
