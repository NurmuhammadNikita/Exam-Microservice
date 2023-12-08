using Microsoft.EntityFrameworkCore;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.PaymentsRepository
{
    internal class PaymentRepository
    {
        private readonly RivendellDB _context;


        public PaymentRepository(RivendellDB context)
        {
            _context = context;

        }

        public async ValueTask<Payment> CreateAsync(Payment model)
        {
            Payment Payment = new Payment()
            {
                

            };

            await _context.Payments.AddAsync(Payment);
            await _context.SaveChangesAsync();

            return Payment;
        }

        public async ValueTask<Payment> DeleteAsync(Guid Id)
        {
            Payment Payment = await _context.Payments.FirstOrDefaultAsync(x => x.Id == Id);
            if (Payment == null)
            {
                return (new Payment());
            }
            else
            {
                _context.Payments.Remove(Payment);
                await _context.SaveChangesAsync();
                return (Payment);
            }
        }

        public async ValueTask<IList<Payment>> GetAllAsync()
        {
            IList<Payment> Payments = await _context.Payments.ToListAsync();

            return (Payments);
        }

        public ValueTask<Payment> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Payment> UpdateAsync(Guid Id, Payment model)
        {
            var Payment = await _context.Payments.FirstOrDefaultAsync(x => x.Id == Id);
            if (Payment == null)
            {
                return (new Payment());
            }
            else
            {
                

                _context.Payments.Update(Payment);
                await _context.SaveChangesAsync();
                return (Payment);

            }
        }
    }
}
