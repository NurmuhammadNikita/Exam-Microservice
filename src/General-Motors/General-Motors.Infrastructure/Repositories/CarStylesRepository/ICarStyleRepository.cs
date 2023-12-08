using General_Motors.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.CarStyleStylesRepository
{
    public interface ICarStyleRepository
    {
        public ValueTask<CarStyle> CreateAsync(CarStyle model);
        public ValueTask<CarStyle> UpdateAsync(Guid Id, CarStyle model);
        public ValueTask<CarStyle> DeleteAsync(Guid Id);
        public ValueTask<CarStyle> GetByIdAsync(Guid Id);
        public ValueTask<IList<CarStyle>> GetAllAsync();
    }
}
