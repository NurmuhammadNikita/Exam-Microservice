using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.Repositories.CarsRepository;

namespace General_Motors.Application.Services.CarsService
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }


        public async ValueTask<Car> CreateAsync(CarDto dto)
        {
            Car car = new Car()
            {
                Id = Guid.NewGuid(),
               CarsStyleId = dto.CarsStyleId,
               CarColor = dto.CarColor,
               Price = dto.Price,

            };
            var result = await _repository.CreateAsync(car);

            return result;
        }

        public async ValueTask<Car> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Car>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Car> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Car> UpdateAsync(Guid conId, CarDto dto)
        {

            Car car = new Car()
            {
                
            };

            var result = await _repository.UpdateAsync(conId, car);

            return result;
        }
    }
}
