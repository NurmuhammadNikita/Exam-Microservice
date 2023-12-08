using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Domain.Tables.Models
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public ComputerToGame gameToComputer { get; set; }

        

    }
}
