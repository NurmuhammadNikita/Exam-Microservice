using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.PaymentsRepository
{
    public class PaymentRepository
    {
        private readonly GMDB _context;


        public PaymentRepository(GMDB context)
        {
            _context = context;

        }

        public async ValueTask<Payment> CreateAsync(Payment model)
        {
            await _context.Payments.AddAsync(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async ValueTask<Payment> DeleteAsync(Guid Id)
        {
            Payment payment = await _context.Payments.FirstOrDefaultAsync(x => x.Id == Id);

            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
            return (payment);

        }

        public async ValueTask<IList<Payment>> GetAllAsync()
        {
            IList<Payment> payments = await _context.Payments.ToListAsync();

            return (payments);
        }

        public async ValueTask<Payment> GetByIdAsync(Guid Id)
        {
            Payment payment = await _context.Payments.FirstOrDefaultAsync(x => x.Id == Id);

            return (payment);
        }

        public async ValueTask<Payment> UpdateAsync(Guid Id, Payment model)
        {
            var payment = await _context.Payments.FirstOrDefaultAsync(x => x.Id == Id);
            if (payment == null)
            {
                return (new Payment());
            }
            else
            {
                payment.BuyerId = model.BuyerId;
                payment.CarId = model.CarId;
                payment.CreatedAt = model.CreatedAt;
                payment.UpdatedAt = model.UpdatedAt;
                payment.CreatedBy = model.CreatedBy;
                payment.UpdatedBy = model.UpdatedBy;
                

                _context.Payments.Update(payment);
                await _context.SaveChangesAsync();
                return (payment);

            }
        }
    }
}
