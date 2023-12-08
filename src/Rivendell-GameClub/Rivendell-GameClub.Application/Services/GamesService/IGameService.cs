using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.GamesService
{
    public interface IGameService
    {
        public ValueTask<Game> CreateAsync(GameDto dto);
        public ValueTask<IList<Game>> GetAllAsync();
        public ValueTask<Game> GetByIdAsync(Guid id);
        public ValueTask<Game> UpdateAsync(Guid conId, GameDto dto);
        public ValueTask<Game> DeleteAsync(Guid id);
    }
}
