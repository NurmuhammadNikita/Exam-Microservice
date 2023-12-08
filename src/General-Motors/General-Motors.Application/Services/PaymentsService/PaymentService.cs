using General_Motors.Application.DTOs;
using General_Motors.Domain.Tables.Entities;
using General_Motors.Domain.Tables.Models;
using General_Motors.Infrastructure.Repositories.BuyersRepository;
using General_Motors.Infrastructure.Repositories.PaymentsRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.Services.PaymentsService
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
                BuyerId = dto.BuyerId,
                CarId = dto.CarId,
                CreatedAt = DateTime.Now.Date.ToString(),
               
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
                
            };

            var result = await _repository.UpdateAsync(conId, payment);

            return result;
        }
    }
}
