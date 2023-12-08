using Rivendell_GameClub.Domain.Tables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.GamesRepository
{
    public interface IGameRepository
    {
        public ValueTask<Game> CreateAsync(Game model);
        public ValueTask<Game> UpdateAsync(Guid Id, Game model);
        public ValueTask<Game> DeleteAsync(Guid Id);
        public ValueTask<Game> GetByIdAsync(Guid Id);
        public ValueTask<IList<Game>> GetAllAsync();
    }
}
