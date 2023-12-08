using Microsoft.EntityFrameworkCore;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.DataAccess;

namespace Rivendell_GameClub.Infrastructure.Repositories.ComputersRepository
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly RivendellDB _context;


        public ComputerRepository(RivendellDB context)
        {
            _context = context;

        }

        public async ValueTask<Computer> CreateAsync(Computer model)
        {

            await _context.Computers.AddAsync(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async ValueTask<Computer> DeleteAsync(Guid Id)
        {
            Computer computer = await _context.Computers.FirstOrDefaultAsync(x => x.Id == Id);
            if (computer == null)
            {
                return (new Computer());
            }
            else
            {
                _context.Computers.Remove(computer);
                await _context.SaveChangesAsync();
                return (computer);
            }
        }

        public async ValueTask<IList<Computer>> GetAllAsync()
        {
            IList<Computer> Computers = await _context.Computers.ToListAsync();

            return (Computers);
        }

        public ValueTask<Computer> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Computer> UpdateAsync(Guid Id, Computer model)
        {
            var computer = await _context.Computers.FirstOrDefaultAsync(x => x.Id == Id);
            if (computer == null)
            {
                return (new Computer());
            }
            else
            {
                computer.Id = Id;
                computer.Processor = model.Processor;
                computer.Number = model.Number;
                computer.ManucaptureDate = model.ManucaptureDate;
                computer.VideoCard = model.VideoCard;


                _context.Computers.Update(computer);
                await _context.SaveChangesAsync();
                return (computer);

            }
        }
    }
}
