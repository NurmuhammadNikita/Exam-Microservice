using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Domain.Tables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rivendell_GameClub.Application.Services.UsersService
{
    public interface IUserService
    {
        public ValueTask<User> CreateAsync(UserDto dto);
        public ValueTask<IList<User>> GetAllAsync();
        public ValueTask<User> GetByIdAsync(Guid id);
        public ValueTask<User> UpdateAsync(Guid conId, UserDto dto);
        public ValueTask<User> DeleteAsync(Guid id);
    }
}
