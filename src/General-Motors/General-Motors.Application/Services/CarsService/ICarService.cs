using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.CarsService
{
    public interface ICarService
    {
        public ValueTask<Car> CreateAsync(CarDto dto);
        public ValueTask<IList<Car>> GetAllAsync();
        public ValueTask<Car> GetByIdAsync(Guid id);
        public ValueTask<Car> UpdateAsync(Guid conId, CarDto dto);
        public ValueTask<Car> DeleteAsync(Guid id);
    }
}
