using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.Repositories.PaymentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.PaymentsService
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repository;

        public PaymentService(IPaymentRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<Payment> CreateAsync(PaymentDto dto)
        {
            Payment payment = new Payment()
            {
                Id = Guid.NewGuid(),
                UserId = dto.UserId,
                ComputerId = dto.ComputerId,
                PaymentTime = DateTime.Now.ToString(),
                Amount = dto.Amount,

                
            };
            var result = await _repository.CreateAsync(payment);

            return result;
        }

        public async ValueTask<Payment> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Payment>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Payment> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Payment> UpdateAsync(Guid conId, PaymentDto dto)
        {

            Payment payment = new Payment()
            {
                Id = conId,
                UserId = dto.UserId,
                ComputerId = dto.ComputerId,
                PaymentTime = DateTime.Now.ToString(),
                Amount = dto.Amount,
            };

            var result = await _repository.UpdateAsync(conId, payment);

            return result;
        }
    }
}
