using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Entities;
using Rivendell_GameClub.Infrastructure.Repositories.UsersRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.UsersService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }




        public async ValueTask<User> CreateAsync(UserDto dto)
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,             
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };
            var result = await _repository.CreateAsync(user);

            return result;
        }

        public async ValueTask<User> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);

            return result;
        }

        public async ValueTask<IList<User>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();

            return result;
        }

        public async ValueTask<User> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);

            return result;
        }

        public async ValueTask<User> UpdateAsync(Guid conId, UserDto dto)
        {

            User user = new User()
            {
                Id = conId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
            };

            var result = await _repository.UpdateAsync(conId, user);

            return result;
        }
    }
}
