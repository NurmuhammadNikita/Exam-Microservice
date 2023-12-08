using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Motors.Application.DTOs
{
    public class CarDto
    {
        public Guid CarsStyleId { get; set; }
        public long Price { get; set; }
        public string CarColor { get; set; }
    }
}
