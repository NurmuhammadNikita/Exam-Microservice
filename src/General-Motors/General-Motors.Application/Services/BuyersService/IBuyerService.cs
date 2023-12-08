using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.BuyersService
{
    public interface IBuyerService
    {
        public ValueTask<Buyer> CreateAsync(BuyerDto dto);
        public ValueTask<IList<Buyer>> GetAllAsync();
        public ValueTask<Buyer> GetByIdAsync(Guid id);
        public ValueTask<Buyer> UpdateAsync(Guid conId, BuyerDto dto);
        public ValueTask<Buyer> DeleteAsync(Guid id);
    }
}
