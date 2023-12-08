using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Domain.Tables
{
    public class ComputerToGame
    {
        public Guid Id { get; set; }
        public Guid ComputerId { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Computer Computer { get; set; }
    }
}
