using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Domain.Tables.Models
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid BuyerId { get; set; }
        public Guid CarId { get; set; }
        public string? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
