using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using General_Motors.Infrastructure.Repositories.BuyersRepository;
using General_Motors.Infrastructure.Repositories.VendorsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.VendorsService
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _repository;

        public VendorService(IVendorRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<Vendor> CreateAsync(VendorDto dto)
        {
            Vendor vendor = new Vendor()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MiddleName = dto.MiddleName,
                PassportSeries = dto.PassportSeries,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };
            var result = await _repository.CreateAsync(vendor);

            return result;
        }

        public async ValueTask<Vendor> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Vendor>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Vendor> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Vendor> UpdateAsync(Guid conId, VendorDto dto)
        {

            Vendor vendor = new Vendor()
            {
                Id = conId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                MiddleName = dto.MiddleName,
                PassportSeries = dto.PassportSeries,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };

            var result = await _repository.UpdateAsync(conId, vendor);

            return result;
        }
    }
}
