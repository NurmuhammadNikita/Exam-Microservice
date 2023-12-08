using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.CarsRepository
{
    public class CarRepository : ICarRepository
    {
        private readonly GMDB _context;


        public CarRepository(GMDB context)
        {
            _context = context;

        }

        public async ValueTask<Car> CreateAsync(Car model)
        {
            Car car = new Car()
            {
                Id = Guid.NewGuid(),
                CarColor = model.CarColor,
                CarsStyleId = model.CarsStyleId,
                Price = model.Price,
                
            };

            await _context.Cars.AddAsync(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public async ValueTask<Car> DeleteAsync(Guid Id)
        {
            Car car = await _context.Cars.FirstOrDefaultAsync(x => x.Id == Id);
            if (car == null)
            {
                return (new Car());
            }
            else
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return (car);
            }
        }

        public async ValueTask<IList<Car>> GetAllAsync()
        {
            IList<Car> Cars = await _context.Cars.ToListAsync();

            return (Cars);
        }

        public ValueTask<Car> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Car> UpdateAsync(Guid Id, Car model)
        {
            var car = await _context.Cars.FirstOrDefaultAsync(x => x.Id == Id);
            if (car == null)
            {
                return (new Car());
            }
            else
            {
                car.CarColor = model.CarColor;
                car.CarsStyleId = model.CarsStyleId;
                car.Price = model.Price;

                _context.Cars.Update(car);
                await _context.SaveChangesAsync();
                return (car);

            }
        }
    }
}
