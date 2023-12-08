using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using General_Motors.Infrastructure.Repositories.BuyersRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.BuyersService
{
    public class BuyerService : IBuyerService
    {

        private readonly IBuyerRepository _repository;

        public BuyerService(IBuyerRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<Buyer> CreateAsync(BuyerDto dto)
        {
            Buyer buyer = new Buyer()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MiddleName = dto.MiddleName,
                PassportSeries = dto.PassportSeries,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };
            var result = await _repository.CreateAsync(buyer);
              
            return  result;      
        }

        public async ValueTask<Buyer> DeleteAsync(Guid id)
        {
           var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Buyer>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Buyer> GetByIdAsync(Guid id)
        {
         var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Buyer> UpdateAsync(Guid conId, BuyerDto dto)
        {

            Buyer buyer = new Buyer()
            {
                Id = conId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MiddleName = dto.MiddleName,
                PassportSeries = dto.PassportSeries,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };

            var result = await _repository.UpdateAsync(conId, buyer);

            return result;
        }

        
    }
}
