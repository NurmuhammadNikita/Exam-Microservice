using Microsoft.EntityFrameworkCore;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Infrastructure.Repositories.GamesRepository
{
    public class GameRepository : IGameRepository
    {
        private readonly RivendellDB _context;


        public GameRepository(RivendellDB context)
        {
            _context = context;

        }

        public async ValueTask<Game> CreateAsync(Game model)
        {
            Game Game = new Game()
            {
                

            };

            await _context.Games.AddAsync(Game);
            await _context.SaveChangesAsync();

            return Game;
        }

        public async ValueTask<Game> DeleteAsync(Guid Id)
        {
            Game Game = await _context.Games.FirstOrDefaultAsync(x => x.Id == Id);
            if (Game == null)
            {
                return (new Game());
            }
            else
            {
                _context.Games.Remove(Game);
                await _context.SaveChangesAsync();
                return (Game);
            }
        }

        public async ValueTask<IList<Game>> GetAllAsync()
        {
            IList<Game> Games = await _context.Games.ToListAsync();

            return (Games);
        }

        public ValueTask<Game> GetByIdAsync(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<Game> UpdateAsync(Guid Id, Game model)
        {
            var Game = await _context.Games.FirstOrDefaultAsync(x => x.Id == Id);
            if (Game == null)
            {
                return (new Game());
            }
            else
            {
               

                _context.Games.Update(Game);
                await _context.SaveChangesAsync();
                return (Game);

            }
        }
    }
}
