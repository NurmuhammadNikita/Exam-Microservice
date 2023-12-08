using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Domain.Tables.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public Guid CarsStyleId {  get; set; }
        public long Price { get; set; }
        public string CarColor { get; set; }

    }
}
