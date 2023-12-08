using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Models;

namespace General_Motors.Application.Services.CarStylesService
{
    public interface ICarStyleService
    {
        public ValueTask<CarStyle> CreateAsync(CarStyleDto dto);
        public ValueTask<IList<CarStyle>> GetAllAsync();
        public ValueTask<CarStyle> GetByIdAsync(Guid id);
        public ValueTask<CarStyle> UpdateAsync(Guid conId, CarStyleDto dto);
        public ValueTask<CarStyle> DeleteAsync(Guid id);
    }
}
