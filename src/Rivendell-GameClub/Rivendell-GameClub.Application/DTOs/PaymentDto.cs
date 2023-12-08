using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.DTOs
{
    public class PaymentDto
    {
        public Guid UserId { get; set; }
        public Guid ComputerId { get; set; }     
        public string Amount { get; set; }

    }
}
