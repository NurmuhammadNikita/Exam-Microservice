using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.Repositories.ComputersRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.ComputersService
{
    public class ComputerService : IComputerService
    {
        private readonly IComputerRepository _repository;

        public ComputerService(IComputerRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<Computer> CreateAsync(ComputerDto dto)
        {
            Computer Computer = new Computer()
            {
               Id = Guid.NewGuid(),
               Number = dto.Number,
               ManucaptureDate = dto.ManucaptureDate,
               Processor = dto.Processor,
               VideoCard = dto.VideoCard,
            };
            var result = await _repository.CreateAsync(Computer);

            return result;
        }

        public async ValueTask<Computer> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Computer>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Computer> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Computer> UpdateAsync(Guid conId, ComputerDto dto)
        {

            Computer Computer = new Computer()
            {
                Id = conId,
                Number = dto.Number,
                ManucaptureDate = dto.ManucaptureDate,
                Processor = dto.Processor,
                VideoCard = dto.VideoCard,
            };

            var result = await _repository.UpdateAsync(conId, Computer);

            return result;
        }
    }
}
