using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Domain.Tables.Models
{
    public class Computer
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public  string ManucaptureDate { get; set; }
        public string Processor {  get; set; }
        public string VideoCard { get; set; }

        public ComputerToGame computerToGame {  get; set; }
    }
}
