using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.Repositories.CarsRepository;
using General_Motors.Infrastructure.Repositories.CarStyleStylesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.CarStylesService
{
    public class CarStyleService
    {
        private readonly ICarStyleRepository _repository;

        public CarStyleService(ICarStyleRepository repository)
        {
            _repository = repository;
        }


        public async ValueTask<CarStyle> CreateAsync(CarStyleDto dto)
        {
            CarStyle carStyle = new CarStyle()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,

            };
            var result = await _repository.CreateAsync(carStyle);

            return result;
        }

        public async ValueTask<CarStyle> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<CarStyle>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<CarStyle> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<CarStyle> UpdateAsync(Guid conId, CarStyleDto dto)
        {

            CarStyle CarStyle = new CarStyle()
            {

            };

            var result = await _repository.UpdateAsync(conId, CarStyle);

            return result;
        }
    }
}
