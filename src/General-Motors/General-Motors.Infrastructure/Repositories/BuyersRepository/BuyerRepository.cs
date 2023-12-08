using General_Motors.Domain.Tables.Entities;
using General_Motors.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.BuyersRepository
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly GMDB _context;
        

        public BuyerRepository(GMDB context)
        {
            _context = context;
           
        }

        public async ValueTask<Buyer> CreateAsync(Buyer model)
        {         
            await _context.Buyers.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async ValueTask<Buyer> DeleteAsync(Guid Id)
        {
            Buyer buyer = await _context.Buyers.FirstOrDefaultAsync(x => x.Id == Id);
            
                _context.Buyers.Remove(buyer);
                await _context.SaveChangesAsync();
                return (buyer);
            
        }

        public async ValueTask<IList<Buyer>> GetAllAsync()
        {
            IList<Buyer> buyers = await _context.Buyers.ToListAsync();

            return(buyers);
        }

        public async ValueTask<Buyer> GetByIdAsync(Guid Id)
        {
            Buyer buyer = await _context.Buyers.FirstOrDefaultAsync(x => x.Id == Id);

            return (buyer);
        }

        public async ValueTask<Buyer> UpdateAsync(Guid Id, Buyer model)
        {
            var buyer = await _context.Buyers.FirstOrDefaultAsync(x => x.Id == Id);
            if (buyer == null)
            {
                return (new Buyer());
            }
            else
            {
                buyer.FirstName = model.FirstName;
                buyer.LastName = model.LastName;
                buyer.MiddleName = model.MiddleName;
                buyer.PassportSeries = model.PassportSeries;
                buyer.PhoneNumber = model.PhoneNumber;
                buyer.Email = model.Email;

                _context.Buyers.Update(buyer);
                await _context.SaveChangesAsync();
                return (buyer);

            }
        }
    }
}
