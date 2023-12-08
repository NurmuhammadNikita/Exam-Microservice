using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Models;
using Rivendell_GameClub.Infrastructure.Repositories.GamesRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.GamesService
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<Game> CreateAsync(GameDto dto)
        {
            Game game = new Game()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Version = dto.Version,

                
            };
            var result = await _repository.CreateAsync(game);

            return result;
        }

        public async ValueTask<Game> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<Game>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<Game> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<Game> UpdateAsync(Guid conId, GameDto dto)
        {

            Game game = new Game()
            {
                Id = conId,
                Name = dto.Name,
                Version = dto.Version,
            };

            var result = await _repository.UpdateAsync(conId, game);

            return result;
        }
    }
}
