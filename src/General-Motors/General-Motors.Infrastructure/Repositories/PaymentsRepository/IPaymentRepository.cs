using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Infrastructure.Repositories.PaymentsRepository
{
    public interface IPaymentRepository
    {
        public ValueTask<Payment> CreateAsync(Payment model);
        public ValueTask<Payment> UpdateAsync(Guid Id, Payment model);
        public ValueTask<Payment> DeleteAsync(Guid Id);
        public ValueTask<Payment> GetByIdAsync(Guid Id);
        public ValueTask<IList<Payment>> GetAllAsync();
    }
}
