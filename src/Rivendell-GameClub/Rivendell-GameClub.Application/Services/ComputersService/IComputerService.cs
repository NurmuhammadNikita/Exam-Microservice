using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.ComputersService
{
    public interface IComputerService
    {
        public ValueTask<Computer> CreateAsync(ComputerDto dto);
        public ValueTask<IList<Computer>> GetAllAsync();
        public ValueTask<Computer> GetByIdAsync(Guid id);
        public ValueTask<Computer> UpdateAsync(Guid conId, ComputerDto dto);
        public ValueTask<Computer> DeleteAsync(Guid id);
    }
}
