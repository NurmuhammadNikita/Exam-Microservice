using General_Motors.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.BuyersRepository
{
    public interface IBuyerRepository
    {
        public ValueTask<Buyer> CreateAsync(Buyer model);
        public ValueTask<Buyer> UpdateAsync(Guid Id, Buyer model);
        public ValueTask<Buyer> DeleteAsync(Guid Id);
        public ValueTask<Buyer> GetByIdAsync(Guid Id);
        public ValueTask<IList<Buyer>> GetAllAsync();       
        //public ValueTask<long> GetCountAsync();
    }
}
