using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.PaymentsRepository
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
