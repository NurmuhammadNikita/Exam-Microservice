using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.VendorsService
{
    public interface IVendorService
    {
        public ValueTask<Vendor> CreateAsync(VendorDto dto);
        public ValueTask<IList<Vendor>> GetAllAsync();
        public ValueTask<Vendor> GetByIdAsync(Guid id);
        public ValueTask<Vendor> UpdateAsync(Guid conId, VendorDto dto);
        public ValueTask<Vendor> DeleteAsync(Guid id);
    }
}
