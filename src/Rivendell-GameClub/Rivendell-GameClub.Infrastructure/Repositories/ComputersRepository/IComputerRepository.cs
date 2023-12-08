using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.ComputersRepository
{
    public interface IComputerRepository 
    {
        public ValueTask<Computer> CreateAsync(Computer model);
        public ValueTask<Computer> UpdateAsync(Guid Id, Computer model);
        public ValueTask<Computer> DeleteAsync(Guid Id);
        public ValueTask<Computer> GetByIdAsync(Guid Id);
        public ValueTask<IList<Computer>> GetAllAsync();
    }
}
