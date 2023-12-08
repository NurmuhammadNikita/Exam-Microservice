using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.PaymentsService
{
    public interface IPaymentService
    {
        public ValueTask<Payment> CreateAsync(PaymentDto dto);
        public ValueTask<IList<Payment>> GetAllAsync();
        public ValueTask<Payment> GetByIdAsync(Guid id);
        public ValueTask<Payment> UpdateAsync(Guid conId, PaymentDto dto);
        public ValueTask<Payment> DeleteAsync(Guid id);
    }
}
