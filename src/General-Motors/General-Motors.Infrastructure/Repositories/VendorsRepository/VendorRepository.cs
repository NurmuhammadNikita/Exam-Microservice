using General_Motors.Domain.Tables.Entities;
using General_Motors.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.VendorsRepository
{
    public class VendorRepository : IVendorRepository
    {
        private readonly GMDB _context;


        public VendorRepository(GMDB context)
        {
            _context = context;

        }

        public async ValueTask<Vendor> CreateAsync(Vendor model)
        {
            Vendor Vendor = new Vendor()
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                PassportSeries = model.PassportSeries,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
            };

            await _context.Vendors.AddAsync(Vendor);
            await _context.SaveChangesAsync();

            return Vendor;
        }

        public async ValueTask<Vendor> DeleteAsync(Guid Id)
        {
            Vendor Vendor = await _context.Vendors.FirstOrDefaultAsync(x => x.Id == Id);
            if (Vendor == null)
            {
                return (new Vendor());
            }
            else
            {
                _context.Vendors.Remove(Vendor);
                await _context.SaveChangesAsync();
                return (Vendor);
            }
        }

        public async ValueTask<IList<Vendor>> GetAllAsync()
        {
            IList<Vendor> Vendors = await _context.Vendors.ToListAsync();

            return (Vendors);
        }

        public ValueTask<Vendor> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Vendor> UpdateAsync(Guid Id, Vendor model)
        {
            var Vendor = await _context.Vendors.FirstOrDefaultAsync(x => x.Id == Id);
            if (Vendor == null)
            {
                return (new Vendor());
            }
            else
            {
                Vendor.FirstName = model.FirstName;
                Vendor.LastName = model.LastName;
                Vendor.MiddleName = model.MiddleName;
                Vendor.PassportSeries = model.PassportSeries;
                Vendor.PhoneNumber = model.PhoneNumber;
                Vendor.Email = model.Email;

                _context.Vendors.Update(Vendor);
                await _context.SaveChangesAsync();
                return (Vendor);

            }
        }
    }
}
