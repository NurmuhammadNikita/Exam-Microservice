using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Domain.Tables.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ComputerId { get; set; }
        public string PaymentTime { get; set; }
        public string Amount { get; set; }  
         
    }
}
