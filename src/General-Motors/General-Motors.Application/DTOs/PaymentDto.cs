using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.DTOs
{
    public class PaymentDto
    {
        public Guid BuyerId { get; set; }
        public Guid CarId { get; set; }      
    }
}
