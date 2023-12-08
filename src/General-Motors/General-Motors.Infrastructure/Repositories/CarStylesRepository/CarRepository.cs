using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.DataAccess;
using General_Motors.Infrastructure.Repositories.CarStyleStylesRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.CarStylesRepository
{
    public class CarRepository : ICarStyleRepository
    {
        private readonly GMDB _context;


        public CarRepository(GMDB context)
        {
            _context = context;

        }

        public async ValueTask<CarStyle> CreateAsync(CarStyle model)
        {
            CarStyle carstyle = new CarStyle()
            {
                Id = Guid.NewGuid(),
                Name = model.Name,

            };

            await _context.CarStyles.AddAsync(carstyle);
            await _context.SaveChangesAsync();

            return carstyle;
        }

        public async ValueTask<CarStyle> DeleteAsync(Guid Id)
        {
            CarStyle carStyle = await _context.CarStyles.FirstOrDefaultAsync(x => x.Id == Id);
            if (carStyle == null)
            {
                return (new CarStyle());
            }
            else
            {
                _context.CarStyles.Remove(carStyle);
                await _context.SaveChangesAsync();
                return (carStyle);
            }
        }

        public async ValueTask<IList<CarStyle>> GetAllAsync()
        {
            IList<CarStyle> Cars = await _context.CarStyles.ToListAsync();

            return (Cars);
        }

        public ValueTask<CarStyle> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<CarStyle> UpdateAsync(Guid Id, CarStyle model)
        {
            var carStyle = await _context.CarStyles.FirstOrDefaultAsync(x => x.Id == Id);
            if (carStyle == null)
            {
                return (new CarStyle());
            }
            else
            {
                carStyle.Id = Id;
                carStyle.Name = model.Name;

                _context.CarStyles.Update(carStyle);
                await _context.SaveChangesAsync();
                return (carStyle);

            }
        }
    }
}
