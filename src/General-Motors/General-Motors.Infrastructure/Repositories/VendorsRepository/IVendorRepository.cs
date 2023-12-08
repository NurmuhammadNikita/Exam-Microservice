using General_Motors.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.VendorsRepository
{
    public interface IVendorRepository
    {
        public ValueTask<Vendor> CreateAsync(Vendor model);
        public ValueTask<Vendor> UpdateAsync(Guid Id, Vendor model);
        public ValueTask<Vendor> DeleteAsync(Guid Id);
        public ValueTask<Vendor> GetByIdAsync(Guid Id);
        public ValueTask<IList<Vendor>> GetAllAsync();
    }
}
