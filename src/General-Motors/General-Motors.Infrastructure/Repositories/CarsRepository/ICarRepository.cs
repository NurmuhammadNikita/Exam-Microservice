using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.CarsRepository
{
    public interface ICarRepository
    {
        public ValueTask<Car> CreateAsync(Car model);
        public ValueTask<Car> UpdateAsync(Guid Id, Car model);
        public ValueTask<Car> DeleteAsync(Guid Id);
        public ValueTask<Car> GetByIdAsync(Guid Id);
        public ValueTask<IList<Car>> GetAllAsync();
    }
}
